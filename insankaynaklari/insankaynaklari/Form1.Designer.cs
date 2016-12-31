namespace insankaynaklari
{
    partial class Form1
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
            this.lblElemanTuru = new System.Windows.Forms.Label();
            this.cmboxElemanturu = new System.Windows.Forms.ComboBox();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.numudTckimlik = new System.Windows.Forms.NumericUpDown();
            this.numudMaas = new System.Windows.Forms.NumericUpDown();
            this.lblMaas = new System.Windows.Forms.Label();
            this.numudSatisadedi = new System.Windows.Forms.NumericUpDown();
            this.lblSatisadedi = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstboxCalısanlar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numudTckimlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSatisadedi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElemanTuru
            // 
            this.lblElemanTuru.AutoSize = true;
            this.lblElemanTuru.Location = new System.Drawing.Point(12, 9);
            this.lblElemanTuru.Name = "lblElemanTuru";
            this.lblElemanTuru.Size = new System.Drawing.Size(67, 13);
            this.lblElemanTuru.TabIndex = 1;
            this.lblElemanTuru.Text = "Eleman Türü";
            // 
            // cmboxElemanturu
            // 
            this.cmboxElemanturu.FormattingEnabled = true;
            this.cmboxElemanturu.Items.AddRange(new object[] {
            "Eleman Türü"});
            this.cmboxElemanturu.Location = new System.Drawing.Point(12, 25);
            this.cmboxElemanturu.Name = "cmboxElemanturu";
            this.cmboxElemanturu.Size = new System.Drawing.Size(121, 21);
            this.cmboxElemanturu.TabIndex = 2;
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(12, 49);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(67, 13);
            this.lblTcKimlikNo.TabIndex = 3;
            this.lblTcKimlikNo.Text = "Tc Kimlik No";
            // 
            // numudTckimlik
            // 
            this.numudTckimlik.Location = new System.Drawing.Point(12, 65);
            this.numudTckimlik.Name = "numudTckimlik";
            this.numudTckimlik.Size = new System.Drawing.Size(120, 20);
            this.numudTckimlik.TabIndex = 4;
            // 
            // numudMaas
            // 
            this.numudMaas.Location = new System.Drawing.Point(12, 109);
            this.numudMaas.Name = "numudMaas";
            this.numudMaas.Size = new System.Drawing.Size(120, 20);
            this.numudMaas.TabIndex = 6;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(12, 93);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(33, 13);
            this.lblMaas.TabIndex = 5;
            this.lblMaas.Text = "Maas";
            // 
            // numudSatisadedi
            // 
            this.numudSatisadedi.Location = new System.Drawing.Point(12, 148);
            this.numudSatisadedi.Name = "numudSatisadedi";
            this.numudSatisadedi.Size = new System.Drawing.Size(98, 20);
            this.numudSatisadedi.TabIndex = 8;
            // 
            // lblSatisadedi
            // 
            this.lblSatisadedi.AutoSize = true;
            this.lblSatisadedi.Location = new System.Drawing.Point(12, 132);
            this.lblSatisadedi.Name = "lblSatisadedi";
            this.lblSatisadedi.Size = new System.Drawing.Size(60, 13);
            this.lblSatisadedi.TabIndex = 7;
            this.lblSatisadedi.Text = "Satis Adedi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(116, 148);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(17, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "button1";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 174);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstboxCalısanlar
            // 
            this.lstboxCalısanlar.FormattingEnabled = true;
            this.lstboxCalısanlar.Location = new System.Drawing.Point(139, 9);
            this.lstboxCalısanlar.Name = "lstboxCalısanlar";
            this.lstboxCalısanlar.Size = new System.Drawing.Size(241, 186);
            this.lstboxCalısanlar.TabIndex = 11;
            this.lstboxCalısanlar.SelectedIndexChanged += new System.EventHandler(this.lstboxCalısanlar_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 205);
            this.Controls.Add(this.lstboxCalısanlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.numudSatisadedi);
            this.Controls.Add(this.lblSatisadedi);
            this.Controls.Add(this.numudMaas);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.numudTckimlik);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.cmboxElemanturu);
            this.Controls.Add(this.lblElemanTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numudTckimlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numudSatisadedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElemanTuru;
        private System.Windows.Forms.ComboBox cmboxElemanturu;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.NumericUpDown numudTckimlik;
        private System.Windows.Forms.NumericUpDown numudMaas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.NumericUpDown numudSatisadedi;
        private System.Windows.Forms.Label lblSatisadedi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstboxCalısanlar;
    }
}

