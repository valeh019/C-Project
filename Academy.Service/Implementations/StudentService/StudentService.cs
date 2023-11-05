
using Academy.core.Enums;
using Academy.core.Models;
using Academy.core.Repositories;
using Academy.Data;
using Academy.Service.Interfaces;

namespace Academy.Service.Services.Implimentations
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();
        public async Task<string> CreateAsync(string fullName, string group, double average, Specialty specialty)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return "fullname bosdur";
            }
            if (string.IsNullOrWhiteSpace(group))
            {
                return "group bosdur";
            }
            if (average < 0)
            {

                return "average 0dan kicik olmamalidir";
            }

            Student student = new Student(fullName, group, average, specialty);
            student.CreatAt = DateTime.UtcNow.AddHours(4);
            await _studentRepository.AddAsync(student);
            return "Successfully Create";
        }

        public async Task GetAllAsync()
        {
            List<Student> students = await _studentRepository.GetAllAsync();

            foreach (Student student in students)
            {
                Console.WriteLine($"Id:{student.id},fullname:{student.FullName},average:{student.average},studentEducation:{student.Specialty},create:{student.CreatAt},update:{student.UpdatedAt}");
            }
        }

        public async Task<string> GetAsync(string id)
        {
            Student student = await _studentRepository.GetAsync(x => x.id == id);
            if (student == null)
                return "Student not found";

            Console.WriteLine($"Id:{student.id},fullname:{student.FullName},average:{student.average},studentEducation:{student.Specialty},create:{student.CreatAt},update:{student.UpdatedAt}");
            return "successfull";
        }

        public async Task<string> RemoveAsync(string id)
        {
            Student student = await _studentRepository.GetAsync(x => x.id == id);
            if (student == null)
            {
                Console.WriteLine("Student not to found");
            }

            await _studentRepository.RemoveAsync(student);
            return "Remove successfull";
        }

        public Task<string> UpdateAsync(string FullName, string Group, string group, double average, Specialty specialty)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> UptadedAsync(string id, string fullName, string group, double average, Specialty specialty)
        {
            Student student = await _studentRepository.GetAsync(x => x.id == id);

            if (string.IsNullOrWhiteSpace(fullName))

                return "fullname bosdur";

            if (string.IsNullOrWhiteSpace(group))

                return "group bosdur";

            if (average < 0)

                return "average 0dan kicik olmamalidir";


            if (student == null)

                return "Student not to found";

            student.id = id;
            student.FullName = fullName;
            student.Group = group;
            student.average = average;
            student.Specialty = specialty;
            student.UpdatedAt = DateTime.UtcNow.AddHours(4);
            return "Uptaded successfully :)";
        }

        Task IStudentService.AddAsync(Student student)
        {
            throw new NotImplementedException();
        }

        Task<string> IStudentService.UpdateAsync(string FullName, string Group, double average, Specialty specialty)
        {
            throw new NotImplementedException();
        }
    }
}
