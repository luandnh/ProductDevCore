using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class ProductAttributesExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.ProductAttributes GetByKey(this IQueryable<NesopsService.Data.Entities.ProductAttributes> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductAttributes> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.ProductAttributes> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.ProductAttributes> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductAttributes> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.ProductAttributes>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.ProductAttributes> ByProductId(this IQueryable<NesopsService.Data.Entities.ProductAttributes> queryable, Guid productId)
        {
            return queryable.Where(q => q.ProductId == productId);
        }

        #endregion

    }
}
