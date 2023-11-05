using Academy.core.Enums;
using Academy.core.Models.BaseModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.core.Models
{
    public class Student : BaseModel
    {
        static int _id;
        public string FullName { get; set; }
        public string Group { get; set; }
        public double average { get; set; }
        public Specialty Specialty { get; set; }
        public DateTime CreatAt { get; set; }

        public Student(string FullName, string Group, double average, Specialty specialty)
        {
            _id++;
            string studentName = Specialty.ToString();
            this.id = $"{studentName[0]}-{_id}";
            this.FullName = FullName;
            this.Group = Group;
            this.average = average;
            this.Specialty = specialty;

        }


    }
}
