namespace WFAProject3_OOP
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_adsoyad = new System.Windows.Forms.TextBox();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.nud_yas = new System.Windows.Forms.NumericUpDown();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_ListeyeDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_yas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Adres:";
            // 
            // tb_adsoyad
            // 
            this.tb_adsoyad.Location = new System.Drawing.Point(140, 18);
            this.tb_adsoyad.Name = "tb_adsoyad";
            this.tb_adsoyad.Size = new System.Drawing.Size(228, 31);
            this.tb_adsoyad.TabIndex = 1;
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(140, 53);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(228, 31);
            this.mtb_telefon.TabIndex = 2;
            // 
            // nud_yas
            // 
            this.nud_yas.Location = new System.Drawing.Point(140, 90);
            this.nud_yas.Margin = new System.Windows.Forms.Padding(5);
            this.nud_yas.Name = "nud_yas";
            this.nud_yas.Size = new System.Drawing.Size(120, 31);
            this.nud_yas.TabIndex = 3;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(140, 129);
            this.tb_adres.Multiline = true;
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(228, 118);
            this.tb_adres.TabIndex = 4;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(140, 253);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(228, 54);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_ListeyeDon
            // 
            this.btn_ListeyeDon.Location = new System.Drawing.Point(140, 313);
            this.btn_ListeyeDon.Name = "btn_ListeyeDon";
            this.btn_ListeyeDon.Size = new System.Drawing.Size(228, 54);
            this.btn_ListeyeDon.TabIndex = 5;
            this.btn_ListeyeDon.Text = "Listeye Dön";
            this.btn_ListeyeDon.UseVisualStyleBackColor = true;
            this.btn_ListeyeDon.Click += new System.EventHandler(this.btn_ListeyeDon_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 396);
            this.Controls.Add(this.btn_ListeyeDon);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.nud_yas);
            this.Controls.Add(this.mtb_telefon);
            this.Controls.Add(this.tb_adsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nud_yas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_adsoyad;
        private MaskedTextBox mtb_telefon;
        private NumericUpDown nud_yas;
        private TextBox tb_adres;
        private Button btn_kaydet;
        private Button btn_ListeyeDon;
    }
}