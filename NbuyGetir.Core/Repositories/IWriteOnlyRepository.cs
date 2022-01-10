﻿using NbuyGetir.Core.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Repositories
{

    //Kayıt işlemlerinden sorumlu
    //add, update delete 
    public interface IWriteOnlyRepository<TEntity> where TEntity : IAggregateRoots
    {

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(string key);
        void Save();



    }
}
