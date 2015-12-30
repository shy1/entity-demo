﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private MusicStoreDataContext context = null;

        protected DbSet<T> DbSet
        {
            get; set;
        }

        public Repository()
        {
            context = new MusicStoreDataContext();
            DbSet = context.Set<T>();
        }

        public Repository(MusicStoreDataContext context)
        {
            this.context = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}