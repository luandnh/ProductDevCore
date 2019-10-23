using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class OrdersExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.Orders GetByKey(this IQueryable<NesopsService.Data.Entities.Orders> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Orders> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Orders> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Orders> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Orders> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Orders>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.Orders> ByUserId(this IQueryable<NesopsService.Data.Entities.Orders> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
