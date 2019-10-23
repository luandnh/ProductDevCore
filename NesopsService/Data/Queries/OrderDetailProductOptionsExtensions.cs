using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class OrderDetailProductOptionsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.OrderDetailProductOptions GetByKey(this IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.OrderDetailProductOptions> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.OrderDetailProductOptions> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.OrderDetailProductOptions> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.OrderDetailProductOptions>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> ByOrderDetailId(this IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> queryable, Guid orderDetailId)
        {
            return queryable.Where(q => q.OrderDetailId == orderDetailId);
        }

        public static IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> ByProductOptionId(this IQueryable<NesopsService.Data.Entities.OrderDetailProductOptions> queryable, Guid productOptionId)
        {
            return queryable.Where(q => q.ProductOptionId == productOptionId);
        }

        #endregion

    }
}
