using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetRolesExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.AspNetRoles GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetRoles> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetRoles> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetRoles> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetRoles> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetRoles> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.AspNetRoles>(task);
        }

        public static NesopsService.Data.Entities.AspNetRoles GetByNormalizedName(this IQueryable<NesopsService.Data.Entities.AspNetRoles> queryable, string normalizedName)
        {
            return queryable.FirstOrDefault(q => (q.NormalizedName == normalizedName || (normalizedName == null && q.NormalizedName == null)));
        }

        public static Task<NesopsService.Data.Entities.AspNetRoles> GetByNormalizedNameAsync(this IQueryable<NesopsService.Data.Entities.AspNetRoles> queryable, string normalizedName)
        {
            return queryable.FirstOrDefaultAsync(q => (q.NormalizedName == normalizedName || (normalizedName == null && q.NormalizedName == null)));
        }

        #endregion

    }
}
