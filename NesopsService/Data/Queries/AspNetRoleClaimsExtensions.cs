using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetRoleClaimsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.AspNetRoleClaims GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetRoleClaims> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetRoleClaims> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetRoleClaims> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetRoleClaims> queryable, int id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetRoleClaims> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.AspNetRoleClaims>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.AspNetRoleClaims> ByRoleId(this IQueryable<NesopsService.Data.Entities.AspNetRoleClaims> queryable, Guid roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        #endregion

    }
}
