using System.Transactions;

namespace Event_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Button btn1 = new Button("ASA");
            //Button btn2 = new Button("HIRU");
            //Button btn3 = new Button("BAN");

            //btn1.OnClick += btn_OnClick;
            //btn2.OnClick += btn_OnClick;
            //btn3.OnClick += btn_OnClick;
            ////Mo phong tao giao dien co 3 nut
            //while (true)
            //{
            //    Console.WriteLine("1. Button Asa");
            //    Console.WriteLine("2. Button Hiru");
            //    Console.WriteLine("3. Button Ban");
            //    Console.WriteLine("3. Button Ban");
            //    Console.Write("Please choose an option: ");
            //    int option = Convert.ToInt32(Console.ReadLine());
            //    switch (option)
            //    {
            //        case 1:
            //            {
            //                btn1.Click();
            //                break;
            //            }
            //        case 2:
            //            {
            //                btn2.Click();
            //                break;
            //            }
            //        case 3:
            //            {
            //                btn3.Click();
            //                break;
            //            }
            //        case 0: return;
            //    }
            Console.Write("Enter number of text: ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<TextBox> list = new List<TextBox>();
            List<CheckBox> list2 = new List<CheckBox>();
            for (int i = 1; i <= num; i++)
            {
                Console.Write($"Enter text {i}: ");
                string text = Console.ReadLine();
                TextBox txt = new TextBox(text);
                CheckBox c = new CheckBox(text);
                list.Add(txt);
                list2.Add(c);
            }
            Console.WriteLine("List of text: ");
            foreach (TextBox txt in list)
            {
                Console.WriteLine($"    - {txt.Text}");
            }
            while (true)
            {
                Console.WriteLine("Press an addCheck button!");
                int i = 1;
                foreach(CheckBox cb in list2)
                {
                    Console.WriteLine($"Check {i}: {cb.Name}");
                    i++;
                }
                Console.Write("Choose a checkbox to change: ");
                int index = Convert.ToInt32(Console.ReadLine());
                CheckBox c = list2.ElementAt(index - 1);
                c.OnCheckChanged += c_OnCheckChanged;
                Console.WriteLine("0. Checked");
                Console.WriteLine("1. UnChecked");
                int option = Convert.ToInt32(Console.ReadLine());
                if (c.Checked && option == 0) Console.WriteLine("Do Ngu");
                else if (!c.Checked && option == 1) Console.WriteLine("Do Ngu");
                else if(c.Checked && option == 1)
                {
                    c.Checked = false;
                    c.Click();
                }
                else
                {
                    c.Checked = true;
                    c.Click();
                }
                c.OnCheckChanged -= c_OnCheckChanged; 
            }
        }

        private static void c_OnCheckChanged(string name, bool value)
        {
            string isChecked = value ? "Checked" : "UnChecked";
            Console.WriteLine($"CheckBox {name}: {isChecked}");
        }
    }//end main

        //private static void btn_OnClick(string name)
        //{
        //    Console.Write($"You have click button {name}");
        //}
    }//end class
