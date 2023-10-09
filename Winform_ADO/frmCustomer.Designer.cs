namespace Winform_ADO
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgCustomer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            id_txt = new TextBox();
            name_txt = new TextBox();
            dob_txt = new TextBox();
            label4 = new Label();
            add_btn = new Button();
            update_btn = new Button();
            delete_btn = new Button();
            reset_btn = new Button();
            exit_btn = new Button();
            label5 = new Label();
            address_txt = new TextBox();
            male_rb = new RadioButton();
            female_rb = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(27, 236);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.Height = 29;
            dgCustomer.Size = new Size(706, 231);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 17);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 86);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Birthdate:";
            // 
            // id_txt
            // 
            id_txt.Location = new Point(103, 17);
            id_txt.Name = "id_txt";
            id_txt.ReadOnly = true;
            id_txt.Size = new Size(220, 27);
            id_txt.TabIndex = 4;
            // 
            // name_txt
            // 
            name_txt.Location = new Point(467, 14);
            name_txt.Name = "name_txt";
            name_txt.Size = new Size(213, 27);
            name_txt.TabIndex = 5;
            // 
            // dob_txt
            // 
            dob_txt.Location = new Point(103, 83);
            dob_txt.Name = "dob_txt";
            dob_txt.Size = new Size(220, 27);
            dob_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 86);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(83, 182);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(82, 36);
            add_btn.TabIndex = 9;
            add_btn.Text = "ADD";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(219, 182);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(82, 36);
            update_btn.TabIndex = 10;
            update_btn.Text = "UPDATE";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(350, 182);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(82, 36);
            delete_btn.TabIndex = 11;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // reset_btn
            // 
            reset_btn.Location = new Point(482, 182);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(82, 36);
            reset_btn.TabIndex = 12;
            reset_btn.Text = "RESET";
            reset_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(618, 182);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(82, 36);
            exit_btn.TabIndex = 13;
            exit_btn.Text = "EXIT";
            exit_btn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 149);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 14;
            label5.Text = "Address:";
            // 
            // address_txt
            // 
            address_txt.Location = new Point(103, 146);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(577, 27);
            address_txt.TabIndex = 15;
            // 
            // male_rb
            // 
            male_rb.AutoSize = true;
            male_rb.Location = new Point(492, 84);
            male_rb.Name = "male_rb";
            male_rb.Size = new Size(63, 24);
            male_rb.TabIndex = 16;
            male_rb.TabStop = true;
            male_rb.Text = "Male";
            male_rb.UseVisualStyleBackColor = true;
            // 
            // female_rb
            // 
            female_rb.AutoSize = true;
            female_rb.Location = new Point(561, 84);
            female_rb.Name = "female_rb";
            female_rb.Size = new Size(78, 24);
            female_rb.TabIndex = 17;
            female_rb.TabStop = true;
            female_rb.Text = "Female";
            female_rb.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 479);
            Controls.Add(female_rb);
            Controls.Add(male_rb);
            Controls.Add(address_txt);
            Controls.Add(label5);
            Controls.Add(exit_btn);
            Controls.Add(reset_btn);
            Controls.Add(delete_btn);
            Controls.Add(update_btn);
            Controls.Add(add_btn);
            Controls.Add(label4);
            Controls.Add(dob_txt);
            Controls.Add(name_txt);
            Controls.Add(id_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Name = "frmCustomer";
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox id_txt;
        private TextBox name_txt;
        private TextBox dob_txt;
        private Label label4;
        private Button add_btn;
        private Button update_btn;
        private Button delete_btn;
        private Button reset_btn;
        private Button exit_btn;
        private Label label5;
        private TextBox address_txt;
        private RadioButton male_rb;
        private RadioButton female_rb;
    }
}