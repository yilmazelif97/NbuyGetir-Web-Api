using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories
{

    //interface seggrefation --> ISP , solid prensibi 

    //EF yi hep read hep write işlemleri için kullanılacak 
    public interface IEFRepository<TEntity> :IReadOnlyRepository<TEntity>, IWriteOnlyRepository<TEntity> where TEntity:IAggregateRoots
    {
      

    
    }
}
