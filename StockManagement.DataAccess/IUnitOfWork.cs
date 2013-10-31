using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;

namespace StockManagement.DataAccess
{
    public interface IUnitOfWork
    {
        IRepository<TSet> GetRepository<TSet>() where TSet : class;
        DbTransaction BeginTransaction();
        int Save();
    }
}
