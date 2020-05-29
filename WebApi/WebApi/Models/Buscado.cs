using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Buscado
    {
        public string site_id;
        public string query;
        public IList<Result> results;
        public IList<Result> billboad_results;
        public Paging paging;
        public SortType sort;
        public IList<SortType> available_sorts;
        public IList<Filter> filters;
        public IList<FilterD> available_filters;

    }
}
