using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiStore.Business.Models
{
    public class ErrorDetailsModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; internal set; }

    }
}
