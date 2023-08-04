namespace WFAProject3_OOP
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_YeniMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(19, 18);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(505, 400);
            this.listBox1.TabIndex = 0;
            // 
            // btn_YeniMusteri
            // 
            this.btn_YeniMusteri.Location = new System.Drawing.Point(19, 426);
            this.btn_YeniMusteri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_YeniMusteri.Name = "btn_YeniMusteri";
            this.btn_YeniMusteri.Size = new System.Drawing.Size(505, 77);
            this.btn_YeniMusteri.TabIndex = 1;
            this.btn_YeniMusteri.Text = "Yeni Müşteri Ekle";
            this.btn_YeniMusteri.UseVisualStyleBackColor = true;
            this.btn_YeniMusteri.Click += new System.EventHandler(this.btn_YeniMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 516);
            this.Controls.Add(this.btn_YeniMusteri);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button btn_YeniMusteri;
    }
}