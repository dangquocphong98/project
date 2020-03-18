using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nothing.Web.Common
{
    public class ResultModel<T>
    {
        public List<T> listModel { get; set; }
        public string mess { get; set; }
        public bool status { get; set; }
    }
}
