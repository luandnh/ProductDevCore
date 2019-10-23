using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetUserClaimsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.AspNetUserClaims GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetUserClaims> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserClaims> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetUserClaims> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetUserClaims> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserClaims> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.AspNetUserClaims>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.AspNetUserClaims> ByUserId(this IQueryable<NesopsService.Data.Entities.AspNetUserClaims> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
