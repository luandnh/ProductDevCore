using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetUserLoginsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.AspNetUserLogins GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetUserLogins> queryable, string loginProvider, string providerKey)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserLogins> dbSet)
                return dbSet.Find(loginProvider, providerKey);

            return queryable.FirstOrDefault(q => q.LoginProvider == loginProvider
                && q.ProviderKey == providerKey);
        }

        public static ValueTask<NesopsService.Data.Entities.AspNetUserLogins> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetUserLogins> queryable, string loginProvider, string providerKey)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserLogins> dbSet)
                return dbSet.FindAsync(loginProvider, providerKey);

            var task = queryable.FirstOrDefaultAsync(q => q.LoginProvider == loginProvider
                && q.ProviderKey == providerKey);
            return new ValueTask<NesopsService.Data.Entities.AspNetUserLogins>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.AspNetUserLogins> ByUserId(this IQueryable<NesopsService.Data.Entities.AspNetUserLogins> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
