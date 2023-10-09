using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    public class TextBox
    {
        public string Text { get; set; }
        public TextBox() { }
        public TextBox(string text)
        {
            Text = text;
        }
    }
}
