using System;
using System.Collections.Generic;
using System.Linq;
using Infraestrutura;
using Repositorio.Generic.Utils;
using PagedList;

namespace Repositorio.Generic.Utils
{
    public class PaginatedList<T> : List<T>
    {

        public int PageIndex { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPages { get; private set; }

        public PaginatedList()
        {

        }

        public PaginatedList(IPagedList<T> source, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.TotalItemCount;
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            AddRange(source);
        //    this.AddRange(
        //      desc ? source.OrderByDescending(p => orderby).Skip(PageIndex * PageSize).Take(PageSize)
        //      : source.OrderBy(p => orderby).Skip(PageIndex * PageSize).Take(PageSize));
        }

        public PaginatedList(IQueryable<T> source, int pageIndex, int pageSize,string orderby,bool desc)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            TotalCount = source.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);
            this.AddRange(
              desc ? source.OrderByDescending(p => orderby).ToPagedList(PageIndex,PageSize)
              : source.OrderBy(p => orderby).ToPagedList(PageIndex, PageSize));
        }

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
