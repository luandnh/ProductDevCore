using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class OrderDetailsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.OrderDetails GetByKey(this IQueryable<NesopsService.Data.Entities.OrderDetails> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.OrderDetails> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.OrderDetails> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.OrderDetails> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.OrderDetails> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.OrderDetails>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.OrderDetails> ByOrderId(this IQueryable<NesopsService.Data.Entities.OrderDetails> queryable, Guid orderId)
        {
            return queryable.Where(q => q.OrderId == orderId);
        }

        public static IQueryable<NesopsService.Data.Entities.OrderDetails> ByProductId(this IQueryable<NesopsService.Data.Entities.OrderDetails> queryable, Guid productId)
        {
            return queryable.Where(q => q.ProductId == productId);
        }

        #endregion

    }
}
