using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories
{
    //Okuma işlemlerinden sorumlu, dapper için orda sadece okuma olacak birde listing
    public interface IReadOnlyRepository<TEntity> where TEntity : IAggregateRoots
    {
        TEntity find(string key);
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> lamda);
        IQueryable<TEntity> List(); //order, include, take, skip gibi işlemler için IQueryable yaptık. 

    }
}
