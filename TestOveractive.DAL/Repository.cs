﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TestOveractive.DAL.Contracts;

namespace TestOveractive.DAL
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected TestOveractiveContext DbContext;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(TestOveractiveContext context)
        {
            DbContext = context;
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            DbSet = DbContext.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return DbSet.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null)
        {
            List<TEntity> result;

            if (predicate != null)
                result = DbSet.Where(predicate).ToList();
            else
                result = DbSet.ToList();

            return result;
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public void Delete(int id)
        {
            TEntity existing = DbContext.Find<TEntity>(id);
            if (existing != null) DbSet.Remove(existing);
        }

        public int CommitChanges()
        {
            return DbContext.SaveChanges();
        }

        public Task<int> CommitChangesAsync()
        {
            return DbContext.SaveChangesAsync();
        }

        public void SaveGraph(TEntity entity)
        {
            DbContext.ChangeTracker.TrackGraph(entity, (e) => {
                if (e.Entry.IsKeySet)
                {
                    e.Entry.State = EntityState.Modified;

                }
                else
                {
                    e.Entry.State = EntityState.Added;
                }
            });
        }
    }
}
