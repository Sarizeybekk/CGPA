namespace ganoHesaplama.Formlar
{
    partial class FrmDersEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersEkle));
            this.btnKydt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblAkademisyenAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxHarfNotu = new System.Windows.Forms.ComboBox();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.txtbxDersAd = new System.Windows.Forms.TextBox();
            this.txtbxDersKredi = new System.Windows.Forms.TextBox();
            this.txtbxDersAkts = new System.Windows.Forms.TextBox();
            this.txtbxAkademisyen = new System.Windows.Forms.TextBox();
            this.txtbxDonemi = new System.Windows.Forms.TextBox();
            this.txtbxDersKod = new System.Windows.Forms.TextBox();
            this.lblDersDonem = new System.Windows.Forms.Label();
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKydt
            // 
            this.btnKydt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnKydt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKydt.Location = new System.Drawing.Point(155, 347);
            this.btnKydt.Name = "btnKydt";
            this.btnKydt.Size = new System.Drawing.Size(177, 51);
            this.btnKydt.TabIndex = 0;
            this.btnKydt.Text = "Kaydet";
            this.btnKydt.UseVisualStyleBackColor = false;
            this.btnKydt.Click += new System.EventHandler(this.btnKydt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders Kodu";
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Location = new System.Drawing.Point(6, 79);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(53, 16);
            this.lblDersAd.TabIndex = 6;
            this.lblDersAd.Text = "DersAd";
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Location = new System.Drawing.Point(6, 126);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(70, 16);
            this.lblDersKredi.TabIndex = 7;
            this.lblDersKredi.Text = "Ders Kredi";
            // 
            // lblAkademisyenAdSoyad
            // 
            this.lblAkademisyenAdSoyad.AutoSize = true;
            this.lblAkademisyenAdSoyad.Location = new System.Drawing.Point(6, 213);
            this.lblAkademisyenAdSoyad.Name = "lblAkademisyenAdSoyad";
            this.lblAkademisyenAdSoyad.Size = new System.Drawing.Size(90, 16);
            this.lblAkademisyenAdSoyad.TabIndex = 8;
            this.lblAkademisyenAdSoyad.Text = "Akademisyen";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbxHarfNotu);
            this.groupBox1.Controls.Add(this.btnKydt);
            this.groupBox1.Controls.Add(this.lblHarfNotu);
            this.groupBox1.Controls.Add(this.txtbxDersAd);
            this.groupBox1.Controls.Add(this.txtbxDersKredi);
            this.groupBox1.Controls.Add(this.txtbxDersAkts);
            this.groupBox1.Controls.Add(this.txtbxAkademisyen);
            this.groupBox1.Controls.Add(this.txtbxDonemi);
            this.groupBox1.Controls.Add(this.txtbxDersKod);
            this.groupBox1.Controls.Add(this.lblDersDonem);
            this.groupBox1.Controls.Add(this.lblDersAkts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblAkademisyenAdSoyad);
            this.groupBox1.Controls.Add(this.lblDersKredi);
            this.groupBox1.Controls.Add(this.lblDersAd);
            this.groupBox1.Location = new System.Drawing.Point(127, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 438);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
          
            // 
            // cmbxHarfNotu
            // 
            this.cmbxHarfNotu.FormattingEnabled = true;
            this.cmbxHarfNotu.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cmbxHarfNotu.Location = new System.Drawing.Point(155, 301);
            this.cmbxHarfNotu.Name = "cmbxHarfNotu";
            this.cmbxHarfNotu.Size = new System.Drawing.Size(177, 24);
            this.cmbxHarfNotu.TabIndex = 22;
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(6, 301);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(63, 16);
            this.lblHarfNotu.TabIndex = 19;
            this.lblHarfNotu.Text = "Harf Notu";
            // 
            // txtbxDersAd
            // 
            this.txtbxDersAd.Location = new System.Drawing.Point(155, 73);
            this.txtbxDersAd.Name = "txtbxDersAd";
            this.txtbxDersAd.Size = new System.Drawing.Size(177, 22);
            this.txtbxDersAd.TabIndex = 18;
            // 
            // txtbxDersKredi
            // 
            this.txtbxDersKredi.Location = new System.Drawing.Point(155, 120);
            this.txtbxDersKredi.Name = "txtbxDersKredi";
            this.txtbxDersKredi.Size = new System.Drawing.Size(177, 22);
            this.txtbxDersKredi.TabIndex = 17;
            // 
            // txtbxDersAkts
            // 
            this.txtbxDersAkts.Location = new System.Drawing.Point(155, 167);
            this.txtbxDersAkts.Name = "txtbxDersAkts";
            this.txtbxDersAkts.Size = new System.Drawing.Size(177, 22);
            this.txtbxDersAkts.TabIndex = 16;
            // 
            // txtbxAkademisyen
            // 
            this.txtbxAkademisyen.Location = new System.Drawing.Point(155, 210);
            this.txtbxAkademisyen.Name = "txtbxAkademisyen";
            this.txtbxAkademisyen.Size = new System.Drawing.Size(177, 22);
            this.txtbxAkademisyen.TabIndex = 15;
            // 
            // txtbxDonemi
            // 
            this.txtbxDonemi.Location = new System.Drawing.Point(155, 256);
            this.txtbxDonemi.Name = "txtbxDonemi";
            this.txtbxDonemi.Size = new System.Drawing.Size(177, 22);
            this.txtbxDonemi.TabIndex = 14;
            // 
            // txtbxDersKod
            // 
            this.txtbxDersKod.Location = new System.Drawing.Point(155, 29);
            this.txtbxDersKod.Name = "txtbxDersKod";
            this.txtbxDersKod.Size = new System.Drawing.Size(177, 22);
            this.txtbxDersKod.TabIndex = 13;
            // 
            // lblDersDonem
            // 
            this.lblDersDonem.AutoSize = true;
            this.lblDersDonem.Location = new System.Drawing.Point(6, 256);
            this.lblDersDonem.Name = "lblDersDonem";
            this.lblDersDonem.Size = new System.Drawing.Size(86, 16);
            this.lblDersDonem.TabIndex = 11;
            this.lblDersDonem.Text = "Ders Dönemi";
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Location = new System.Drawing.Point(6, 173);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(65, 16);
            this.lblDersAkts.TabIndex = 9;
            this.lblDersAkts.Text = "Ders Akts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(194, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ders Ekleme Formu";
            // 
            // FrmDersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDersEkle";
            this.Text = "frmDersEkle";
           
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKydt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.Label lblDersKredi;
        private System.Windows.Forms.Label lblAkademisyenAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDersAkts;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.TextBox txtbxDersAd;
        private System.Windows.Forms.TextBox txtbxDersKredi;
        private System.Windows.Forms.TextBox txtbxDersAkts;
        private System.Windows.Forms.TextBox txtbxAkademisyen;
        private System.Windows.Forms.TextBox txtbxDonemi;
        private System.Windows.Forms.TextBox txtbxDersKod;
        private System.Windows.Forms.Label lblDersDonem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxHarfNotu;
    }
}