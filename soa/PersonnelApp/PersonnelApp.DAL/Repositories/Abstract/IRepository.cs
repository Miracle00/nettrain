﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Add(TEntity entity);

        void AddRange(List<TEntity> entities);

        void Remove(int id);

        void RemoveRange(List<TEntity> entities);
    }
}
