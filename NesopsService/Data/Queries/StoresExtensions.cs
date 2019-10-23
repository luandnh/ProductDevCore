using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class StoresExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.Stores GetByKey(this IQueryable<NesopsService.Data.Entities.Stores> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Stores> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Stores> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Stores> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Stores> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Stores>(task);
        }

        #endregion

    }
}
