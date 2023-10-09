using Microsoft.Data.SqlClient;
using System.Data;
using WinForm_ADO;

namespace Winform_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataProvider dp = new DataProvider();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cach 1
            //String sql = $"select * from Users where Account = '{textBox1.Text}' and Password = '{textBox2.Text}'";
            //DataTable dt = dp.executeQuery(sql);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Login success!");
            //}
            //else MessageBox.Show("Login fail!");

            //Cach 2
            String sql = "select * from Users where Account = @acc and Password = @pass";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@acc",textBox1.Text),
                new SqlParameter("@pass", textBox2.Text)
            };
            IDataReader dr = dp.executeQuery2(sql,sp);
            if(dr.Read())
            {
                dr.Close();
                string? name = GetNameByAccount(textBox1.Text);
                frmCustomer fc = new frmCustomer(name);
                fc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login fail!");
            }
            dr.Close();
        }

        public string? GetNameByAccount(string name)
        {
            String sql = $"select Name from Users where Account = '{name}'";
            DataTable dt = dp.executeQuery(sql);
            string? _name = "";
            if (dt.Rows.Count > 0)
            {
                _name = dt.Rows[0]["Name"].ToString();
            }
            
            return _name;
        }
    }
}