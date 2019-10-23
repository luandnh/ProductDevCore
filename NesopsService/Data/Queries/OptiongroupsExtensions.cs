using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NesopsService.Data.Queries
{
    public static partial class OptiongroupsExtensions
    {
        #region Generated Extensions
        public static NesopsService.Data.Entities.Optiongroups GetByKey(this IQueryable<NesopsService.Data.Entities.Optiongroups> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Optiongroups> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<NesopsService.Data.Entities.Optiongroups> GetByKeyAsync(this IQueryable<NesopsService.Data.Entities.Optiongroups> queryable, Guid id)
        {
            if (queryable is DbSet<NesopsService.Data.Entities.Optiongroups> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<NesopsService.Data.Entities.Optiongroups>(task);
        }

        #endregion

    }
}
