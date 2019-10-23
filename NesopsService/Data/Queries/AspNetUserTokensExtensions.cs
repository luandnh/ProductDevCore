using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class AspNetUserTokensExtensions
    {
        #region Generated Extensions
        public static IQueryable<NesopsService.Data.Entities.AspNetUserTokens> ByUserId(this IQueryable<NesopsService.Data.Entities.AspNetUserTokens> queryable, Guid userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        public static NesopsService.Data.Entities.AspNetUserTokens GetByKey(this IQueryable<NesopsService.Data.Entities.AspNetUserTokens> queryable, Guid userId, string loginProvider, string name)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserTokens> dbSet)
                return dbSet.Find(userId, loginProvider, name);

            return queryable.FirstOrDefault(q => q.UserId == userId
                && q.LoginProvider == loginProvider
                    && q.Name == name);
            }

            public static ValueTask<NesopsService.Data.Entities.AspNetUserTokens> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.AspNetUserTokens> queryable, Guid userId, string loginProvider, string name)
            {
                if (queryable is DbSet<NesopsService.Data.Entities.AspNetUserTokens> dbSet)
                    return dbSet.FindAsync(userId, loginProvider, name);

                var task = queryable.FirstOrDefaultAsync(q => q.UserId == userId
                    && q.LoginProvider == loginProvider
                        && q.Name == name);
                    return new ValueTask<NesopsService.Data.Entities.AspNetUserTokens>(task);
                }

                #endregion

            }
        }
