using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public abstract class Teacher : IComparable<Teacher>
    {
        private string _code;
        private string _name;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Teacher() { }

        public Teacher(string code, string name)
        {
            Code = code;
            Name = name;
        }

        public override string? ToString()
        {
            return Code + ": " + Name + ": " + GetSalary();
        }

        public abstract double GetSalary();

        public int CompareTo(Teacher other)
        {
            if (GetSalary() > other.GetSalary()) return 1;
            if (GetSalary() == other.GetSalary()) return 0;
            else return -1;
        }
    }
}
