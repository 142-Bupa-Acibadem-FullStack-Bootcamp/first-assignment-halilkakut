using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Abstract
{
    public interface IUnitOfWork :IDisposable
    {
        bool BeginTransaction();
        bool RollBackTransaction();
<<<<<<< HEAD
        int SaveChanges(); 
=======
        int SaveChanges();
>>>>>>> 44d8fc68657769417d38072580a8205f8e2ab250
    }
}
