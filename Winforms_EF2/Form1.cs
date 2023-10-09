using Winforms_EF2.Models;

namespace Winforms_EF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (var context = new MySaleDBContext())
            {
                var customers = context.Customers.Select(s => new
                {
                    ID = s.CustomerId,
                    Name = s.CustomerName,
                    Dob = s.Birthdate,
                    Address = s.Address,
                    isMale = s.Gender,
                    isFemale = !s.Gender
                }).ToList();

                dgCustomer.DataSource = customers;
                //lay du lieu tu bang category add vao combobox
                var categories = context.Categories.ToList();
                //binding data
                id_txt.DataBindings.Clear();
                id_txt.DataBindings.Add("Text", customers, "ID");

                dob_txt.DataBindings.Clear();
                dob_txt.DataBindings.Add("Text", customers, "Dob");

                name_txt.DataBindings.Clear();
                name_txt.DataBindings.Add("Text", customers, "Name");

                address_txt.DataBindings.Clear();
                address_txt.DataBindings.Add("Text", customers, "Address");

                male_rb.DataBindings.Clear();
                male_rb.DataBindings.Add("Checked", customers, "isMale");

                female_rb.DataBindings.Clear();
                female_rb.DataBindings.Add("Checked", customers, "isFemale");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}