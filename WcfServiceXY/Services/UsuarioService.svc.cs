using Repositorio;
using Model;


namespace WcfServiceXY.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UsuarioService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UsuarioService.svc or UsuarioService.svc.cs at the Solution Explorer and start debugging.
    public class UsuarioService : ServiceXY<Usuario, int>, IUsuarioService
    {
        public UsuarioService(UsuarioRepository repository)
        {
            _repo = repository;
        }
    }
}
