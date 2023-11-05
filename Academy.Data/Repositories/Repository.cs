using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Data.Repositories
{
    public class Repository
    {
        List<Task> values = new List<Task>();
        public async Task AddAsync(Task entity)
        {
            values.Add(entity);
        }

        public async Task<List<Task>> GetAllAsync()
        {
            return values;
        }

        public async Task<List<Task>> GetAllAsync(Func<Task, bool> func)
        {
            return values.Where(func).ToList();
        }

        public async Task<Task> GetAsync(Func<Task, bool> func)
        {
            return values.FirstOrDefault(func);
        }

        public async Task RemoveAsync(Task entity)
        {
            values.Remove(entity);
        }

    }
}
