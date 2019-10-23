using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetUsersExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.AspNetUsers GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetUsers> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUsers> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetUsers> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetUsers> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUsers> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.AspNetUsers>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.AspNetUsers> ByNormalizedEmail(this IQueryable<NesopsService.Data.Entities.AspNetUsers> queryable, string normalizedEmail)
        {
            return queryable.Where(q => (q.NormalizedEmail == normalizedEmail || (normalizedEmail == null && q.NormalizedEmail == null)));
        }

        public static NesopsService.Data.Entities.AspNetUsers GetByNormalizedUserName(this IQueryable<NesopsService.Data.Entities.AspNetUsers> queryable, string normalizedUserName)
        {
            return queryable.FirstOrDefault(q => (q.NormalizedUserName == normalizedUserName || (normalizedUserName == null && q.NormalizedUserName == null)));
        }

        public static Task<NesopsService.Data.Entities.AspNetUsers> GetByNormalizedUserNameAsync(this IQueryable<NesopsService.Data.Entities.AspNetUsers> queryable, string normalizedUserName)
        {
            return queryable.FirstOrDefaultAsync(q => (q.NormalizedUserName == normalizedUserName || (normalizedUserName == null && q.NormalizedUserName == null)));
        }

        #endregion

    }
}
