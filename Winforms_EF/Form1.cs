using Winforms_EF.Models;

namespace Winforms_EF
{
    public partial class form1 : Form
    {
        public form1()
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
                var products = context.Products.Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Price = p.UnitPrice,
                    Stock = p.UnitsInStock,
                    Image = p.Image,
                    CategoryName = p.Category.CategoryName,
                }).OrderBy(p => p.Price).ThenByDescending(p => p.Stock).ToList();

                dgProduct.DataSource = products;
                //lay du lieu tu bang category add vao combobox
                var categories = context.Categories.ToList();
                cbo_category.DataSource = categories;
                cbo_category.DisplayMember = "CategoryName";
                cbo_category.ValueMember = "CategoryId";
                //binding data
                id_txt.DataBindings.Clear();
                id_txt.DataBindings.Add("Text", products, "ID");

                price_txt.DataBindings.Clear();
                price_txt.DataBindings.Add("Text", products, "Price");

                name_txt.DataBindings.Clear();
                name_txt.DataBindings.Add("Text", products, "Name");

                image_txt.DataBindings.Clear();
                image_txt.DataBindings.Add("Text", products, "Image");

                stock_txt.DataBindings.Clear();
                stock_txt.DataBindings.Add("Text", products, "Stock");

                cbo_category.DataBindings.Clear();
                cbo_category.DataBindings.Add("Text", products, "CategoryName");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (var context = new MySaleDBContext())
            {
                Product p = new Product()
                {
                    ProductName = name_txt.Text,
                    UnitPrice = Decimal.Parse(price_txt.Text),
                    UnitsInStock = Int32.Parse(stock_txt.Text),
                    Image = image_txt.Text,
                    CategoryId = (int)cbo_category.SelectedValue,
                };
                context.Products.Add(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Add success");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Add fail");
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            using (var context = new MySaleDBContext())
            {
                Product? p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(id_txt.Text));
                p.ProductName = name_txt.Text;
                p.UnitPrice = decimal.Parse(price_txt.Text);
                p.UnitsInStock = Int32.Parse(stock_txt.Text);
                p.Image = image_txt.Text;
                p.CategoryId = (int)cbo_category.SelectedValue;
                context.Products.Update(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update fail");
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (var context = new MySaleDBContext())
            {
                Product? p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(id_txt.Text));
                context.Products.Remove(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete fail");
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (var context = new MySaleDBContext())
            {
                var products = context.Products.Where(p => p.ProductId == Int32.Parse(id_txt.Text)).Select(p => new
                {
                    ID = p.ProductId,
                    Name = p.ProductName,
                    Price = p.UnitPrice,
                    Stock = p.UnitsInStock,
                    Image = p.Image,
                    CategoryName = p.Category.CategoryName
                }).ToList();

                dgProduct.DataSource = products;
                //binding data
                id_txt.DataBindings.Clear();
                id_txt.DataBindings.Add("Text", products, "ID");

                price_txt.DataBindings.Clear();
                price_txt.DataBindings.Add("Text", products, "Price");

                name_txt.DataBindings.Clear();
                name_txt.DataBindings.Add("Text", products, "Name");

                image_txt.DataBindings.Clear();
                image_txt.DataBindings.Add("Text", products, "Image");

                stock_txt.DataBindings.Clear();
                stock_txt.DataBindings.Add("Text", products, "Stock");

                cbo_category.DataBindings.Clear();
                cbo_category.DataBindings.Add("Text", products, "CategoryName");
            }
        }
    }
}