using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class Manager : IManager
    {
        public List<Teacher> Data { get; set; }
        public Manager(List<Teacher> data) 
        {
            Data = data;
        }
        public void InputList(int size) 
        {
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"New data {i+1}: ");
                Console.Write("Enter code: ");
                string code = Console.ReadLine();
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Are you full_time or part_time? (0 - full_time, 1 - part_time): ");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 0)
                {
                    Console.Write("Enter heso: ");
                    double heso = Convert.ToDouble(Console.ReadLine());
                    FullTimeTeacher tc = new FullTimeTeacher(code, name, heso);
                    Data.Add(tc);
                }
                else
                {
                    Console.Write("Enter slot: ");
                    int slot = Convert.ToInt32(Console.ReadLine());
                    PartTimeTeacher tc = new PartTimeTeacher(code, name, slot);
                    Data.Add(tc);
                }
            } 
        }
        public void OutputList()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.ToString());
            }
        }
        //Show list of teachers with the highest salary.
        public void Function3()
        {
            Data.Sort();
            double salary = Data.ElementAt(0).GetSalary();
            foreach(Teacher tc in Data)
            {
                if (tc.GetSalary() == salary) Console.WriteLine(tc.ToString());
            }
        }
        public List<Teacher> GetPtTeacherList(List<Teacher> data)
        {
            List<Teacher> list = new List<Teacher>();
            foreach(Teacher pt in data)
            {
                if (pt.GetType() == typeof(PartTimeTeacher))
                {
                    list.Add(pt);
                }
            }
            return list;
        }
        //How many parttime teachers have the slot > 10.
        public int Function4()
        {
            int count = 0;
            List<Teacher> list = GetPtTeacherList(Data);
            foreach(PartTimeTeacher tc in list)
            {
                if (tc.Slot > 10) count++;
            }
            return count;
        }
        //Calculate the total number of  parttime teacher's slots.
        public int Function5()
        {
            int sum = 0;
            List<Teacher> list = GetPtTeacherList(Data);
            foreach (PartTimeTeacher tc in list)
            {
                sum += tc.Slot;
            }
            return sum;
        }
        //Sort the list of teachers increased by salary.
        public void Function6()
        {
            Data.Sort();
            Data.Reverse();
        }
        //Is there a teacher whose name starts with ‘T’? If so, show that person's name and salary.
        public void Function7()
        {
            foreach(Teacher tc in Data)
            {
                if (tc.Name.StartsWith("T"))
                {
                    Console.WriteLine(tc.Name + ": " + tc.GetSalary());
                }
            }
        }
        //Displays a list of fulltime teachers with the salary coefficient < 3, in which the full name will separate First and Last Names into 2 columns.
        public void Function8()
        {

        }
        public void SaveFile()
        {
            try
            {
                //string filename = "C:\\Users\\Admin\\Documents\\Visual Studio 2022\\CSharp\\PRN211\\OOP_Practice\\Data.txt";
                //StreamWriter sw = new StreamWriter(filename);
                //sw.WriteLine("hello");
                //sw.Close();
                string filename = "C:\\Users\\Admin\\Documents\\Visual Studio 2022\\CSharp\\PRN211\\OOP_Practice\\Data.txt";
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach(var item in Data)
                    {
                        int check = item is FullTimeTeacher ? 0 : 1;
                        sw.WriteLine("{0,10}\t{1,20}\t{2,10}\t{3,10}",item.Code,item.Name,item.GetSalary(),check);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadFile() 
        {
            string filename = "C:\\Users\\Admin\\Documents\\Visual Studio 2022\\CSharp\\PRN211\\OOP_Practice\\Data.txt";
            Data.Clear();
            using (StreamReader sr = new StreamReader(filename))
            {
                string? line = sr.ReadLine();
                while(line != null)
                {
                    string[] data = line.Split("\t");
                    if(data.Length == 4)
                    {
                        string code = data[0];
                        string name = data[1];
                        if (Convert.ToInt32(data[3]) == 0)
                        {
                            double heso = Double.Parse(data[2]) / 200000.0;
                            FullTimeTeacher ft = new FullTimeTeacher(code, name, heso);
                            Data.Add(ft);
                        }
                        else
                        {
                            int slot = Convert.ToInt32(data[3]) / 50000;
                            PartTimeTeacher pt = new PartTimeTeacher(code, name, slot);
                            Data.Add(pt);
                        }
                    }
                    line = sr.ReadLine();
                }
            }
        }
    }
}
