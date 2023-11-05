
using Academy.core.Models;
using Academy.core.Repositories;
using Academy.Data.Repositories;

namespace Academy.Data
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public async Task AddAsync(Student entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllAsync(Func<Student, bool> func)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetAsync(Func<Student, bool> func)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(Student entity)
        {
            throw new NotImplementedException();
        }
    }

    public class Repository<T>
    {
    }
}
