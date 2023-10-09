using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_ADO;

namespace Winform_ADO
{
    public partial class frmCustomer : Form
    {
        public frmCustomer(string? title)
        {
            InitializeComponent();
            Text = title;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        DataProvider dp = new DataProvider();

        private void LoadData()
        {
            List<Customer> data = new List<Customer>();
            string sql = "select * from Customers";
            using (IDataReader dr = dp.executeQuery2(sql))
            {
                while (dr.Read())
                {
                    int id = dr.GetInt32(0);
                    string name = dr.GetString(1);
                    DateTime dob = dr.GetDateTime(2);
                    Boolean gender = dr.GetBoolean(3);
                    string address = dr.GetString(4);
                    Customer c = new Customer(id.ToString(), name, dob.ToString(), gender.ToString(), address);
                    data.Add(c);
                }
                dgCustomer.DataSource = data;
            }
        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            id_txt.Text = dgCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            name_txt.Text = dgCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            dob_txt.Text = dgCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            address_txt.Text = dgCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            male_rb.Checked = dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True");
            female_rb.Checked = dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("False");
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Customers where CustomerID = {id_txt.Text}";
            if (dp.executeNonQuery(sql))
            {
                MessageBox.Show("Delete success");
                LoadData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
        }

        public int GetID()
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(id_txt.Text);
                for (int i = 0; i < dgCustomer.Rows.Count; i++)
                {
                    if (dgCustomer.Rows[i].Cells[0].FormattedValue.ToString().Equals(id.ToString()))
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return id;
        }

        public string GetBirthDate()
        {
            string dob = "";
            try
            {
                DateTime dt = DateTime.Parse(dob_txt.Text);
                dob = dt.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
            return dob;
        }

        public void ResetForm()
        {
            id_txt.Text = string.Empty;
            name_txt.Text = string.Empty;
            dob_txt.Text = string.Empty;
            address_txt.Text = string.Empty;
            male_rb.Checked = false;
            female_rb.Checked = false;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            //int id = GetID();
            //if(id == 0) 
            //{
            //    MessageBox.Show("Invalid ID");
            //    return;
            //}
            //if(id == -1)
            //{
            //    MessageBox.Show("ID has exist");
            //    return;
            //}
            string name = name_txt.Text;
            string dob = GetBirthDate();
            if (dob == "")
            {
                MessageBox.Show("Invalid birthdate with format \"MM-dd-YYYY\"");
                return;
            }
            string? address = address_txt.Text;
            if (!male_rb.Checked && !female_rb.Checked)
            {
                MessageBox.Show("You must select gender");
                return;
            }
            string gender = male_rb.Checked ? "true" : "false";
            string sql = $"insert into Customers values ('{name}','{dob}','{gender}','{address}')";
            bool success = dp.executeNonQuery(sql);
            if (success)
            {
                MessageBox.Show("Add success");
                LoadData();
                ResetForm();
            }
            else MessageBox.Show("Add fail");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text;
            string dob = GetBirthDate();
            if (dob == "")
            {
                MessageBox.Show("Invalid birthdate with format \"MM-dd-YYYY\"");
                return;
            }
            string? address = address_txt.Text;
            if (!male_rb.Checked && !female_rb.Checked)
            {
                MessageBox.Show("You must select gender");
                return;
            }
            string gender = male_rb.Checked ? "true" : "false";
            string sql = $"update Customers set CustomerName = '{name}', Birthdate = '{dob}', Gender = '{gender}', Address = '{address}' where CustomerId = '{id_txt.Text}'";
            bool success = dp.executeNonQuery(sql);
            if (success)
            {
                MessageBox.Show("Update success");
                LoadData();
                ResetForm();
            }
            else MessageBox.Show("Update fail");
        }
    }
}
