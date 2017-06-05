using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Carsales.DAL.Utils
{
    public static class DbModelBuilderExtension
    {
        public static EntityTypeConfiguration<TEntity> Entity<TEntity>(this DbModelBuilder modelBuilder, Action<EntityTypeConfiguration<TEntity>> action) where TEntity : class
        {
            var r = modelBuilder.Entity<TEntity>();
            action(r);
            return r;
        }
    }
}
