using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Wcf_ServiceX.Decorator
{
    public static class EfDynamicProxyAssemblies
    {
        private static readonly object _lock = new object();
        private static readonly Dictionary<string, Assembly> _loadedAssemblies = new Dictionary<string, Assembly>();
        private static readonly HashSet<Assembly> _assembliesToExtract = new HashSet<Assembly>();
        private static readonly List<Type> _dynamixProxies = new List<Type>();

        static EfDynamicProxyAssemblies()
        {
            AppDomain.CurrentDomain.AssemblyLoad += new AssemblyLoadEventHandler(CurrentDomain_AssemblyLoad);
        }

        private static void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            if (args == null || args.LoadedAssembly == null || string.IsNullOrEmpty(args.LoadedAssembly.FullName))
                return;

            lock (_lock)
            {
                if ((args.LoadedAssembly.FullName).StartsWith("EntityFrameworkDynamicProxies") &&
                    !_loadedAssemblies.ContainsKey(args.LoadedAssembly.FullName))
                {
                    _loadedAssemblies.Add(args.LoadedAssembly.FullName, args.LoadedAssembly);
                    _assembliesToExtract.Add(args.LoadedAssembly);
                    //Types aren't generated yet, so we can't add them to _dynamixEntityProxies
                }
            }
        }

        public static IEnumerable<Type> GetTypes()
        {
            lock (_lock)
            {
                var types = _assembliesToExtract.SelectMany(a => a.GetTypes()).ToList();
                _dynamixProxies.AddRange(types);

                _assembliesToExtract.Clear();
            }

            return _dynamixProxies;
        }
    }
}