using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class SubcategoriesExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.Subcategories> ByCategoryId(this IQueryable<NesopsService.Data.Entities.Subcategories> queryable, Guid categoryId)
        {
            return queryable.Where(q => q.CategoryId == categoryId);
        }

        public static NesopsService.Data.Entities.Subcategories GetByKey(this IQueryable<NesopsService.Data.Entities.Subcategories> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Subcategories> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Subcategories> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Subcategories> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Subcategories> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Subcategories>(task);
        }

        #endregion

    }
}
