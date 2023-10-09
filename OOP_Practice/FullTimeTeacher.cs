using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    internal class FullTimeTeacher : Teacher
    {
        public double Heso { get; set; }

        public FullTimeTeacher() { }
        public FullTimeTeacher(string code, string name, double heso) : base(code,name)
        {
            Heso = heso;
        }

        public override double GetSalary()
        {
            return Heso * 2000000;
        }
    }
}
