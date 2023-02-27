using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagementAPP.ModelView
{
    public class NonqueryDataService<T> where T : class
    {

        private readonly Leave_DashboardContextFactory _contextFactory;
        private readonly NonqueryDataService<T> _nonQueryDataService;

        public NonqueryDataService(Leave_DashboardContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        //Creating Create funtion as event
        public async Task<T> Create(T entity)
        {

            using Leave_DashboardDBContext context = _contextFactory.CreateDbContext();
            EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
            return createdResult.Entity;
        }

        //Creating Delete funtion as event
        public async Task<bool> Delete(T entity)
        {

            using Leave_DashboardDBContext context = _contextFactory.CreateDbContext();
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }

        //Creating Update funtion as event
        public async Task<T> Update(T entity)
        {
            using Leave_DashboardDBContext context = _contextFactory.CreateDbContext();
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }
    }
}
