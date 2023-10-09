using System.Linq.Expressions;

namespace OOP_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai bao danh sach Teacher ban dau
            List<Teacher> data = new List<Teacher>()
            {
                new FullTimeTeacher("T01","Ha Quang Dao",1.5),
                new PartTimeTeacher("T02","Dao Xuan Quang",10),
                new FullTimeTeacher("T03","Nguyen Quang Huy",2.0),
                new PartTimeTeacher("T04","Nguyen Thu Diu",8),
                new FullTimeTeacher("T05","Dao Minh Nhat",2.0),
                new FullTimeTeacher("T06","Pham Minh Tien",1.0),
                new PartTimeTeacher("T07","Dao Manh Tuan Cuong",15)
            };
            Manager m = new Manager(data);
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("1. Input list teacher");
                Console.WriteLine("2. Show list teacher");
                Console.WriteLine("3. Show list of teachers with the highest salary.");
                Console.WriteLine("4. How many parttime teachers have the slot > 10.");
                Console.WriteLine("5. Calculate the total number of  parttime teacher's slots.");
                Console.WriteLine("6. Sort the list of teachers increased by salary.");
                Console.WriteLine("7. Is there a teacher whose name starts with ‘T’? If so, show that person's name and salary.");
                Console.WriteLine("8. Save to file");
                Console.WriteLine("9. Load from file");
                Console.WriteLine("0. Exit");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.Write("Enter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0: return;
                    case 1:
                        {
                            Console.Write("Enter size: ");
                            int size = Convert.ToInt32(Console.ReadLine());
                            m.InputList(size);
                            break;
                        }
                    case 2:
                        {
                            m.OutputList();
                            break;
                        }
                    case 3:
                        {
                            m.Function3();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine($"number of part_time teachers have sot > 10: {m.Function4()}");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine($"Total number of slot: {m.Function5()}");
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    case 8:
                        {
                            m.SaveFile();
                            break;
                        }
                    case 9:
                        {
                            m.LoadFile();
                            break;
                        }
                }
            }
        }
    }
}