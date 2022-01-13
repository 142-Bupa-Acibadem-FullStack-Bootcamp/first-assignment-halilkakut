using Northwind.DataAccessLayer.Abstract;
using System;

namespace Northwind.DataAccessLayer.Concrete.Entityframework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public bool BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool RollBackTransaction()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
