using System.DirectoryServices.ActiveDirectory;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private List<Student> data;
        Dictionary<string, string> map;
        public Form1()
        {
            InitializeComponent();
            data = new List<Student>();
            map = new Dictionary<string, string>();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to close?","Alert",MessageBoxButtons.YesNo) == DialogResult.Yes)
            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Student st = new Student()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Subject = cbxSubject.Text,
                Mark = (int)numMark.Value
            };
            if(map.Keys.Contains(st.Code) )
            {
                MessageBox.Show($"{txtCode.Text} da ton tai");
            }
            else
            {
                map.Add(txtCode.Text, txtName.Text);
                data.Add(st);
                lstStudent.Items.Add(st);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            Student s = (Student)lstStudent.SelectedItem;
            if (MessageBox.Show("Do you want to delete this student?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                map.Remove(s.Code);
                data.Remove(s);
                lstStudent.Items.Remove(s);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {;
                string filename = "C:\\Users\\Admin\\Documents\\Visual Studio 2022\\CSharp\\PRN211\\WinformApp\\Data.txt";
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var item in data)
                    {
                        sw.WriteLine("{0,10}\t{1,20}\t{2,10}\t{3,10}",item.Code,item.Name,item.Subject,item.Mark);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            string filename = "C:\\Users\\Admin\\Documents\\Visual Studio 2022\\CSharp\\PRN211\\WinformApp\\Data.txt";
            data.Clear();
            using (StreamReader sr = new StreamReader(filename))
            {
                string? line = sr.ReadLine();
                while (line != null)
                {
                    string[] Data = line.Split("\t");
                    if (Data.Length == 4)
                    {
                        Student s = new Student()
                        {
                            Code = Data[0],
                            Name = Data[1],
                            Subject = Data[2],
                            Mark = Convert.ToInt32(Data[3])
                        };
                        data.Add(s);
                        lstStudent.Items.Add(s);
                        map.Add(s.Code, s.Name);
                    }
                    line = sr.ReadLine();
                }
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            bool check = false;
            foreach(var item in data)
            {
                if (item.Code.Equals(txtCode.Text.Trim()))
                {
                    txtName.Text = item.Name;
                    cbxSubject.Text = item.Subject;
                    numMark.Value = item.Mark;
                    check = true;
                }
                
            }
            if (!check)
            {
                txtName.Text = "";
                cbxSubject.Text = "";
                numMark.Value = 0;
            }
        }
    }
}