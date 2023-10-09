using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    public class CheckBox
    {
        public string Name { get; set; }
        public bool Checked { get; set; }
        public CheckBox() 
        {
            Checked = false;
        }
        public CheckBox(string name) 
        {
            Name = name;
            Checked = false;
        }
        public delegate void eventHandle(string name, bool value);
        public eventHandle OnCheckChanged;
        public void Click()
        {
            if(OnCheckChanged != null)
            {
                OnCheckChanged(Name,Checked);
            }
        }
    }
}
