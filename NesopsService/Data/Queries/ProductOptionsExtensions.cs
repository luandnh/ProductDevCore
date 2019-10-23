using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class ProductOptionsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.ProductOptions GetByKey(this IQueryable<NesopsService.Data.Entities.ProductOptions> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductOptions> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.ProductOptions> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.ProductOptions> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductOptions> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.ProductOptions>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.ProductOptions> ByOptionId(this IQueryable<NesopsService.Data.Entities.ProductOptions> queryable, Guid optionId)
        {
            return queryable.Where(q => q.OptionId == optionId);
        }

        public static IQueryable<NesopsService.Data.Entities.ProductOptions> ByProductId(this IQueryable<NesopsService.Data.Entities.ProductOptions> queryable, Guid productId)
        {
            return queryable.Where(q => q.ProductId == productId);
        }

        #endregion

    }
}
