namespace WinFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.GroupBox();
            this.numMark = new System.Windows.Forms.NumericUpDown();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._code = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.GroupBox();
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).BeginInit();
            this.output.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management";
            // 
            // input
            // 
            this.input.Controls.Add(this.numMark);
            this.input.Controls.Add(this.cbxSubject);
            this.input.Controls.Add(this.txtName);
            this.input.Controls.Add(this.txtCode);
            this.input.Controls.Add(this.label4);
            this.input.Controls.Add(this.label3);
            this.input.Controls.Add(this.label2);
            this.input.Controls.Add(this._code);
            this.input.Location = new System.Drawing.Point(12, 81);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(315, 263);
            this.input.TabIndex = 1;
            this.input.TabStop = false;
            this.input.Text = "Input";
            // 
            // numMark
            // 
            this.numMark.Location = new System.Drawing.Point(108, 180);
            this.numMark.Name = "numMark";
            this.numMark.Size = new System.Drawing.Size(178, 23);
            this.numMark.TabIndex = 7;
            // 
            // cbxSubject
            // 
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Items.AddRange(new object[] {
            "SWP391",
            "PRN211",
            "SWT201",
            "SWR202",
            "ITE302c"});
            this.cbxSubject.Location = new System.Drawing.Point(108, 132);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(178, 23);
            this.cbxSubject.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(178, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Location = new System.Drawing.Point(108, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(178, 23);
            this.txtCode.TabIndex = 4;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mark:";
            // 
            // _code
            // 
            this._code.AutoSize = true;
            this._code.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._code.Location = new System.Drawing.Point(22, 33);
            this._code.Name = "_code";
            this._code.Size = new System.Drawing.Size(58, 22);
            this._code.TabIndex = 0;
            this._code.Text = "Code:";
            // 
            // output
            // 
            this.output.Controls.Add(this.lstStudent);
            this.output.Location = new System.Drawing.Point(425, 81);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(336, 263);
            this.output.TabIndex = 2;
            this.output.TabStop = false;
            this.output.Text = "Output";
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.ItemHeight = 15;
            this.lstStudent.Location = new System.Drawing.Point(16, 22);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(305, 229);
            this.lstStudent.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_btn.Location = new System.Drawing.Point(333, 93);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(86, 26);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remove_btn.Location = new System.Drawing.Point(333, 138);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(86, 26);
            this.remove_btn.TabIndex = 4;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.load_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.load_btn.Location = new System.Drawing.Point(333, 184);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(86, 26);
            this.load_btn.TabIndex = 5;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.save_btn.Location = new System.Drawing.Point(333, 229);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(86, 26);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_btn.Location = new System.Drawing.Point(333, 276);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(86, 26);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 384);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "StudentManagement";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).EndInit();
            this.output.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox input;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label _code;
        private GroupBox output;
        private NumericUpDown numMark;
        private ComboBox cbxSubject;
        private TextBox txtName;
        private TextBox txtCode;
        private ListBox lstStudent;
        private Button add_btn;
        private Button remove_btn;
        private Button load_btn;
        private Button save_btn;
        private Button exit_btn;
    }
}