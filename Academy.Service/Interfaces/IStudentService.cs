using Academy.core.Enums;
using Academy.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Service.Interfaces
{
    public interface IStudentService
    {
        public Task<string> CreateAsync(string FullName, string Group, double average, Specialty specialty);
        public Task<string> UpdateAsync(string FullName, string Group, string? group, double average, Specialty specialty);
        public Task<string> RemoveAsync(string id);
        public Task<string> GetAsync(string id);
        public Task  GetAllAsync();
        Task AddAsync(Student student);
        Task<string> UpdateAsync();
        Task<string> UpdateAsync(string FullName, string Group, double average, Specialty specialty);
    }
}
