using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Infraestructure.Helper
{
    public partial class PagerHelper
    {
        public static int PageSize(string size)
        {
            return (string.IsNullOrEmpty(size)) ? 100 : int.Parse(size);
        }

        public static int PageNumber(string page)
        {
            return (string.IsNullOrEmpty(page)) ? 1 : int.Parse(page);
        }
    }
}
