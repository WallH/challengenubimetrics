using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Filter
    {
        public string id;
        public string name;
        public string type;
        public IList<Aplicado> values;

    }
}
