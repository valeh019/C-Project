
using Academy.core.Enums;
using Academy.Service.Interfaces;


namespace Academy.Service.Services.Implimentations
{
    public class MenuService
    {
        IStudentService studentservice = new StudentService();
        public async Task RunApp()
        {
            await Menu();
            string request = Console.ReadLine();
            async Task Menu()
            {
                Console.WriteLine("1-Create");
                Console.WriteLine("2-Remove");
                Console.WriteLine("3-Update");
                Console.WriteLine("4-Get");
                Console.WriteLine("5-GetAll");
                Console.WriteLine("0-close");
            }

            while (request != "0")
            {
                switch (request)
                {
                    case "1":
                        await CreatStudent();
                        break;
                    case "2":
                        await UpdateStudent();
                        break;
                    case "3":
                        await RemoveAsync();
                        break;
                    case "4":
                        await GetAllAsync();
                        break;
                    case "5":
                        await GetAsync();
                        break;
                    default:
                        Console.WriteLine("zehmet olmasa duz deyer daxil edin");
                        break;
                }
                await Menu();
                request = Console.ReadLine();
            }
        }
        async Task CreatStudent()
        {
            Console.WriteLine("Add FullName");
            string FullName = Console.ReadLine();
            Console.WriteLine("Add Group");
            string Group = Console.ReadLine();
            Console.WriteLine("Add Average");
            double.TryParse(Console.ReadLine(), out double Average);
            int i = 1;
            foreach (var item in Enum.GetValues(typeof(Specialty)))
            {
                Console.WriteLine($"{i}-{item}");
                i++;
            }
            bool isExsist;
            int EnumIndex;
            do
            {
                Console.WriteLine("Add Specialty");
                int.TryParse(Console.ReadLine(), out EnumIndex);
                //isExsist = Enum.IsDefined(typeof(StudentEducation),(StudentEducation)EnumIndex);
                isExsist = Enum.IsDefined(typeof(Specialty), EnumIndex);
            }
            while (!isExsist);

            string result = await studentservice.CreateAsync(FullName, Group, Average, (Specialty)EnumIndex);
            Console.WriteLine(result);
        }
        async Task UpdateStudent()
        {
            Console.WriteLine("Add id");
            string Id = Console.ReadLine();
            Console.WriteLine("Add FullName");
            string FullName = Console.ReadLine();
            Console.WriteLine("Add Group");
            string Group = Console.ReadLine();
            Console.WriteLine("Add Average");
            double.TryParse(Console.ReadLine(), out double Average);
            int i = 1;
            foreach (var item in Enum.GetValues(typeof(Specialty)))
            {
                Console.WriteLine($"{i}-{item}");
                i++;
            }
            bool isExsist;
            int EnumIndex;
            do
            {
                Console.WriteLine("Add ");
                int.TryParse(Console.ReadLine(), out EnumIndex);
                //isExsist = Enum.IsDefined(typeof(StudentEducation),(StudentEducation)EnumIndex);
                isExsist = Enum.IsDefined(typeof(Specialty), (Specialty)EnumIndex);
            }
            while (!isExsist);

            string result = await studentservice.UpdateAsync(Id, FullName, Group, Average, (Specialty)EnumIndex);
            Console.WriteLine(result);
        }
        async Task RemoveAsync()
        {
            Console.WriteLine("Add id:");
            string Id = Console.ReadLine();
            string result = await studentservice.RemoveAsync(Id);
            Console.WriteLine(result);
        }
        async Task GetAllAsync()
        {
            await studentservice.GetAllAsync();
        }
        async Task GetAsync()
        {
            Console.WriteLine("Add id:");
            string Id = Console.ReadLine();
            string result = await studentservice.GetAsync(Id);
            Console.WriteLine(result);
        }
    }
}