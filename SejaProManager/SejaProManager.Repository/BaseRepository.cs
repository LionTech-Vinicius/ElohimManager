using Microsoft.EntityFrameworkCore;
using SejaProManager.Repository.Context;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SejaProManager.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        internal readonly SejaProManagerContext context;
        internal readonly DbSet<T> dbSet;

        public BaseRepository(SejaProManagerContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    Type entityType = typeof(T);

                    PropertyInfo CreatedAtProperty = entityType.GetProperty("CreatedAt");

                    if (CreatedAtProperty != null)
                    {
                        CreatedAtProperty.SetValue(entity, DateTime.Now);
                    }

                    PropertyInfo UpdatedAtProperty = entityType.GetProperty("UpdatedAt");

                    if (UpdatedAtProperty != null)
                    {
                        UpdatedAtProperty.SetValue(entity, DateTime.Now);
                    }

                    await dbSet.AddAsync(entity);
                    await context.SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw ex;
                }
            }
        }

        public async Task Update(T entity)
        {
            using (var transaction = await context.Database.BeginTransactionAsync())
            {
                try
                {
                    Type entityType = typeof(T);

                    PropertyInfo UpdatedAtProperty = entityType.GetProperty("UpdatedAt");

                    if (UpdatedAtProperty != null)
                    {
                        UpdatedAtProperty.SetValue(entity, DateTime.Now);
                    }

                    dbSet.Update(entity);

                    await context.SaveChangesAsync();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();

                    throw ex;
                }
            }
        }

        public DbSet<T> Query()
        {
            return this.dbSet;
        }

        public async Task Delete(T entity)
        {
            if (entity != null)
            {

                Type entityType = typeof(T);

                PropertyInfo ActiveProperty = entityType.GetProperty("Active");
                PropertyInfo UpdatedAtProperty = entityType.GetProperty("UpdatedAt");

                using (var transaction = await context.Database.BeginTransactionAsync())
                {
                    try
                    {
                        //Deleta caso não exista a propriedade Ativo
                        if (ActiveProperty != null)
                        {
                            dbSet.Remove(entity);
                        }
                        else
                        {
                            if (UpdatedAtProperty != null)
                            {
                                UpdatedAtProperty.SetValue(entity, DateTime.Now);
                            }
                            ActiveProperty.SetValue(entity, false);

                            dbSet.Update(entity);
                        }

                        await context.SaveChangesAsync();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        throw ex;
                    }
                }
            }
            else
            {
                throw new ApplicationException("Objeto não encontrado");
            }
        }

    }
}
