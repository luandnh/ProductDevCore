using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetUserRolesExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.AspNetUserRoles> ByRoleId(this IQueryable<NesopsService.Data.Entities.AspNetUserRoles> queryable, Guid roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        public static IQueryable<NesopsService.Data.Entities.AspNetUserRoles> ByUserId(this IQueryable<NesopsService.Data.Entities.AspNetUserRoles> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static NesopsService.Data.Entities.AspNetUserRoles GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetUserRoles> queryable, Guid userId, Guid roleId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserRoles> dbSet)
                return dbSet.Find(userId, roleId);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.RoleId == roleId);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetUserRoles> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetUserRoles> queryable, Guid userId, Guid roleId)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserRoles> dbSet)
                return dbSet.FindAsync(userId, roleId);

            var task = queryable.FirstOrDefaultAsync(q => q.UserId == userId
                && q.RoleId == roleId);
            return new ValueTask<NesopsService.Data.Entities.AspNetUserRoles>(task);
        }

        #endregion

    }
}
