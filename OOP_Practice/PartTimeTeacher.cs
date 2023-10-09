
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class PartTimeTeacher : Teacher
    {
        public int Slot { get; set; }

        public PartTimeTeacher() { }
        public PartTimeTeacher(string code, string name, int slot) : base(code,name)
        {
            Slot = slot;
        }
        public override double GetSalary()
        {
            return Slot * 50000;
        }
    }
}
