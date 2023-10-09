using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public interface IManager
    {
        public void InputList(int size);
        public void OutputList();
        //Show list of teachers with the highest salary.
        public void Function3();
        //How many parttime teachers have the slot > 10.
        public int Function4();
        //Calculate the total number of  parttime teacher's slots.
        public int Function5();
        //Sort the list of teachers increased by salary.
        public void Function6();
        //Is there a teacher whose name starts with ‘T’? If so, show that person's name and salary.
        public void Function7();
        //Displays a list of fulltime teachers with the salary coefficient < 3, in which the full name will separate First and Last Names into 2 columns.
        public void Function8();
        public void SaveFile();
        public void LoadFile();
    }
}
