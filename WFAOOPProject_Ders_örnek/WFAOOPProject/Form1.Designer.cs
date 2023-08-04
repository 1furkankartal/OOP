namespace WFAOOPProject
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lboxMusteriler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(41, 354);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(475, 72);
            this.btnMusteriEkle.TabIndex = 5;
            this.btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lboxMusteriler
            // 
            this.lboxMusteriler.FormattingEnabled = true;
            this.lboxMusteriler.ItemHeight = 30;
            this.lboxMusteriler.Location = new System.Drawing.Point(41, 29);
            this.lboxMusteriler.Name = "lboxMusteriler";
            this.lboxMusteriler.Size = new System.Drawing.Size(475, 274);
            this.lboxMusteriler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 462);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.lboxMusteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMusteriEkle;
        private ListBox lboxMusteriler;
    }
}