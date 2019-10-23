using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class ProductVideosExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.ProductVideos GetByKey(this IQueryable<NesopsService.Data.Entities.ProductVideos> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductVideos> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.ProductVideos> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.ProductVideos> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.ProductVideos> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.ProductVideos>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.ProductVideos> ByProductId(this IQueryable<NesopsService.Data.Entities.ProductVideos> queryable, Guid productId)
        {
            return queryable.Where(q => q.ProductId == productId);
        }

        #endregion

    }
}
