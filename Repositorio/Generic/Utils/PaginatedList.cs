using System;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Generic.Utils
{
    public class PaginatedList<T> : List<T>
    {
        //private IQueryable<object> queryable;

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }


        public PaginatedList() { PageIndex = 0; PageSize = 0; TotalCount = 0; TotalPages = 0; }

        public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize, string order)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            this.AddRange(                
                source.OrderBy(p => order).Skip(PageIndex * PageSize).Take(PageSize)
                );

        }

        //public PaginatedList(IQueryable<object> source, int pageIndex, int pageSize)
        //{
        //    PageIndex = pageIndex;
        //    PageSize = pageSize;
        //    TotalCount = source.Count();
        //    TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

        //    this.AddRange(source.Skip(PageIndex * PageSize).Take(PageSize));
        //}

        //public PaginatedList(IQueryable<object> queryable, int pageIndex, int pageSize)
        //{
        //    this.queryable = queryable;
        //    PageIndex = pageIndex;
        //    PageSize = pageSize;
        //}

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 0);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex + 1 < TotalPages);
            }
        }
    }
}
