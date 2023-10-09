using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    public class Button
    {
        public string Name { get; set; }

        public Button() { }

        public Button(string name) 
        {
            Name = name;
        }
        //Tao su kien xay ra khi nhan nut
        public delegate void eventHandle(string name);
        public eventHandle OnClick;
        
        //Mo phong thao tac nhan nut
        public void Click()
        {
            if (OnClick != null)
            {
                OnClick(Name);
            }
            else Console.WriteLine($"{Name} chua duoc gan su kien");
        }
    }
}
