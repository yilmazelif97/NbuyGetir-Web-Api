using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories
{

    // mongodb .net drive ile crud select işlemleri operasyonşları yapıalcak repository 
    public interface IMongoRepository <TEntity> :IReadOnlyRepository<TEntity>, IWriteOnlyRepository<TEntity> where TEntity:IAggregateRoots
    {
    }
}
