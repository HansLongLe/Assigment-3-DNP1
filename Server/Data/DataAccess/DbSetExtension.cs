using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Server.Data.DataAccess
{
    public static class DbSetExtension
    {
        // ReSharper disable once UnusedMethodReturnValue.Global
        public static EntityEntry<T> AddIfNotExists<T>(this DbSet<T> dbSet, T entity, Expression<Func<T, bool>> predicate = null) where T : class, new()
        {
            var exists = predicate != null ? dbSet.Any(predicate) : dbSet.Any();
            return !exists ? dbSet.Add(entity) : null;
        }
    }
}