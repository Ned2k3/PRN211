namespace Winforms_EF
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgProduct = new DataGridView();
            id_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            price_txt = new TextBox();
            name_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            stock_txt = new TextBox();
            image_txt = new TextBox();
            label5 = new Label();
            label6 = new Label();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            search_btn = new Button();
            exit_btn = new Button();
            cbo_category = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(30, 266);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 51;
            dgProduct.RowTemplate.Height = 29;
            dgProduct.Size = new Size(739, 211);
            dgProduct.TabIndex = 0;
            // 
            // id_txt
            // 
            id_txt.Location = new Point(110, 28);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(176, 27);
            id_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 31);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "Price:";
            // 
            // price_txt
            // 
            price_txt.Location = new Point(110, 84);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(176, 27);
            price_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(571, 28);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(159, 27);
            name_txt.TabIndex = 5;
            name_txt.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 31);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 87);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 7;
            label4.Text = "Stock:";
            // 
            // stock_txt
            // 
            stock_txt.Location = new Point(571, 84);
            stock_txt.Name = "stock_txt";
            stock_txt.Size = new Size(159, 27);
            stock_txt.TabIndex = 8;
            // 
            // image_txt
            // 
            image_txt.Location = new Point(110, 138);
            image_txt.Name = "image_txt";
            image_txt.Size = new Size(176, 27);
            image_txt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 141);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Image:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 141);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Category:";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(110, 210);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 34);
            add_btn.TabIndex = 13;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(244, 210);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 34);
            update_btn.TabIndex = 14;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(380, 210);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 34);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // search_btn
            // 
            search_btn.Location = new Point(524, 210);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(75, 34);
            search_btn.TabIndex = 16;
            search_btn.Text = "SEARCH";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(655, 210);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 34);
            exit_btn.TabIndex = 17;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = true;
            // 
            // cbo_category
            // 
            cbo_category.FormattingEnabled = true;
            cbo_category.Location = new Point(571, 138);
            cbo_category.Name = "cbo_category";
            cbo_category.Size = new Size(159, 28);
            cbo_category.TabIndex = 18;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(cbo_category);
            Controls.Add(exit_btn);
            Controls.Add(search_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(image_txt);
            Controls.Add(stock_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(name_txt);
            Controls.Add(price_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(id_txt);
            Controls.Add(dgProduct);
            Name = "form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduct;
        private TextBox id_txt;
        private Label label1;
        private Label label2;
        private TextBox price_txt;
        private TextBox name_txt;
        private Label label3;
        private Label label4;
        private TextBox stock_txt;
        private TextBox image_txt;
        private Label label5;
        private Label label6;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button search_btn;
        private Button exit_btn;
        private ComboBox cbo_category;
    }
}