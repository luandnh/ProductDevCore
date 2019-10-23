using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class ProductsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.Products GetByKey(this IQueryable<NesopsService.Data.Entities.Products> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Products> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Products> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Products> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Products> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Products>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.Products> BySubcategoryId(this IQueryable<NesopsService.Data.Entities.Products> queryable, Guid subcategoryId)
        {
            return queryable.Where(q => q.SubcategoryId == subcategoryId);
        }

        #endregion

    }
}
