using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class OptionsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.Options GetByKey(this IQueryable<NesopsService.Data.Entities.Options> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Options> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Options> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Options> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Options> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Options>(task);
        }

        public static IQueryable<NesopsService.Data.Entities.Options> ByOptionGroupId(this IQueryable<NesopsService.Data.Entities.Options> queryable, Guid optionGroupId)
        {
            return queryable.Where(q => q.OptionGroupId == optionGroupId);
        }

        #endregion

    }
}
