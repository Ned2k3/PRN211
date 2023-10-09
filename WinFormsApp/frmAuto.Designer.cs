using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp
{
    partial class frmAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.NumericUpDown();
            this.addText_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numText)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(188, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of text: ";
            // 
            // numText
            // 
            this.numText.Location = new System.Drawing.Point(350, 25);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(110, 23);
            this.numText.TabIndex = 1;
            // 
            // addText_btn
            // 
            this.addText_btn.Location = new System.Drawing.Point(475, 25);
            this.addText_btn.Name = "addText_btn";
            this.addText_btn.Size = new System.Drawing.Size(67, 24);
            this.addText_btn.TabIndex = 2;
            this.addText_btn.Text = "Add Text";
            this.addText_btn.UseVisualStyleBackColor = true;
            this.addText_btn.Click += new System.EventHandler(this.addText_btn_Click);
            // 
            // frmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addText_btn);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.label1);
            this.Name = "frmAuto";
            this.Text = "frmAuto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAuto_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmAuto_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private string _text;
        private Label label1;
        private NumericUpDown numText;
        private Button addText_btn;

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        #endregion
    }
}