using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class ProductImagesExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.ProductImages GetByKey(this IQueryable<NesopsService.Data.Entities.ProductImages> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductImages> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.ProductImages> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.ProductImages> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductImages> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.ProductImages>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.ProductImages> ByProductId(this IQueryable<NesopsService.Data.Entities.ProductImages> queryable, Guid productId)
        {
            return queryable.Where(q => q.ProductId == productId);
        }

        #endregion

    }
}
