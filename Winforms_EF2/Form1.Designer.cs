namespace Winforms_EF2
{
    partial class Form1
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
            dgCustomer = new DataGridView();
            id_txt = new TextBox();
            label1 = new Label();
            dob_txt = new TextBox();
            name_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            address_txt = new TextBox();
            label5 = new Label();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            reset_btn = new Button();
            exit_btn = new Button();
            label2 = new Label();
            male_rb = new RadioButton();
            female_rb = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(30, 266);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.Height = 29;
            dgCustomer.Size = new Size(739, 211);
            dgCustomer.TabIndex = 0;
            // 
            // id_txt
            // 
            id_txt.Location = new Point(143, 28);
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
            // dob_txt
            // 
            dob_txt.Location = new Point(143, 84);
            dob_txt.Name = "dob_txt";
            dob_txt.Size = new Size(176, 27);
            dob_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(543, 28);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(159, 27);
            name_txt.TabIndex = 5;
            name_txt.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 31);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 87);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender:";
            // 
            // address_txt
            // 
            address_txt.Location = new Point(143, 141);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(176, 27);
            address_txt.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 141);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(80, 210);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 34);
            add_btn.TabIndex = 13;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(216, 210);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(75, 34);
            update_btn.TabIndex = 14;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(359, 210);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(75, 34);
            delete_btn.TabIndex = 15;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(503, 210);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(75, 34);
            reset_btn.TabIndex = 16;
            reset_btn.Text = "RESET";
            reset_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(636, 210);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(75, 34);
            exit_btn.TabIndex = 17;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 87);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "BirthDate:";
            // 
            // male_rb
            // 
            male_rb.AutoSize = true;
            male_rb.Location = new Point(556, 83);
            male_rb.Name = "male_rb";
            male_rb.Size = new Size(63, 24);
            male_rb.TabIndex = 18;
            male_rb.TabStop = true;
            male_rb.Text = "Male";
            male_rb.UseVisualStyleBackColor = true;
            // 
            // female_rb
            // 
            female_rb.AutoSize = true;
            female_rb.Location = new Point(625, 83);
            female_rb.Name = "female_rb";
            female_rb.Size = new Size(78, 24);
            female_rb.TabIndex = 19;
            female_rb.TabStop = true;
            female_rb.Text = "Female";
            female_rb.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(female_rb);
            Controls.Add(male_rb);
            Controls.Add(exit_btn);
            Controls.Add(reset_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(label5);
            Controls.Add(address_txt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(name_txt);
            Controls.Add(dob_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(id_txt);
            Controls.Add(dgCustomer);
            Name = "form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private TextBox id_txt;
        private Label label1;
        private TextBox dob_txt;
        private TextBox name_txt;
        private Label label3;
        private Label label4;
        private TextBox address_txt;
        private Label label5;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button reset_btn;
        private Button exit_btn;
        private Label label2;
        private RadioButton male_rb;
        private RadioButton female_rb;
    }
}