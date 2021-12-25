using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Base
{
    public class Response : IResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 44d8fc68657769417d38072580a8205f8e2ab250
        public object Data { get; set; }
    }

    public class Response<T> : IResponse<T>
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
