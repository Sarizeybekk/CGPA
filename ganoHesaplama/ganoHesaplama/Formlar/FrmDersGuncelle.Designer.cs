namespace ganoHesaplama.Formlar
{
    partial class FrmDersGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersGuncelle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxHarfNot = new System.Windows.Forms.ComboBox();
            this.cmbxDersKodu = new System.Windows.Forms.ComboBox();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.txtbxDersAd = new System.Windows.Forms.TextBox();
            this.txtbxDersKredi = new System.Windows.Forms.TextBox();
            this.txtbxDersAkts = new System.Windows.Forms.TextBox();
            this.txtbxAkademisyen = new System.Windows.Forms.TextBox();
            this.txtbxDonemi = new System.Windows.Forms.TextBox();
            this.lblDersDonem = new System.Windows.Forms.Label();
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDersGetir = new System.Windows.Forms.Button();
            this.lblAkademisyenAdSoyad = new System.Windows.Forms.Label();
            this.lblDersKredi = new System.Windows.Forms.Label();
            this.lblDersAd = new System.Windows.Forms.Label();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbxHarfNot);
            this.groupBox1.Controls.Add(this.cmbxDersKodu);
            this.groupBox1.Controls.Add(this.lblHarfNotu);
            this.groupBox1.Controls.Add(this.txtbxDersAd);
            this.groupBox1.Controls.Add(this.txtbxDersKredi);
            this.groupBox1.Controls.Add(this.txtbxDersAkts);
            this.groupBox1.Controls.Add(this.txtbxAkademisyen);
            this.groupBox1.Controls.Add(this.txtbxDonemi);
            this.groupBox1.Controls.Add(this.lblDersDonem);
            this.groupBox1.Controls.Add(this.lblDersAkts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDersGetir);
            this.groupBox1.Controls.Add(this.lblAkademisyenAdSoyad);
            this.groupBox1.Controls.Add(this.lblDersKredi);
            this.groupBox1.Controls.Add(this.lblDersAd);
            this.groupBox1.Location = new System.Drawing.Point(113, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 438);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
           
            // 
            // cmbxHarfNot
            // 
            this.cmbxHarfNot.FormattingEnabled = true;
            this.cmbxHarfNot.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cmbxHarfNot.Location = new System.Drawing.Point(102, 391);
            this.cmbxHarfNot.Name = "cmbxHarfNot";
            this.cmbxHarfNot.Size = new System.Drawing.Size(228, 24);
            this.cmbxHarfNot.TabIndex = 25;
            // 
            // cmbxDersKodu
            // 
            this.cmbxDersKodu.FormattingEnabled = true;
            this.cmbxDersKodu.Location = new System.Drawing.Point(102, 29);
            this.cmbxDersKodu.Name = "cmbxDersKodu";
            this.cmbxDersKodu.Size = new System.Drawing.Size(228, 24);
            this.cmbxDersKodu.TabIndex = 24;
            this.cmbxDersKodu.SelectedIndexChanged += new System.EventHandler(this.cmbxDersKodu_SelectedIndexChanged);
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(6, 391);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(63, 16);
            this.lblHarfNotu.TabIndex = 19;
            this.lblHarfNotu.Text = "Harf Notu";
            this.lblHarfNotu.Visible = false;
            // 
            // txtbxDersAd
            // 
            this.txtbxDersAd.Location = new System.Drawing.Point(102, 136);
            this.txtbxDersAd.Name = "txtbxDersAd";
            this.txtbxDersAd.Size = new System.Drawing.Size(227, 22);
            this.txtbxDersAd.TabIndex = 18;
            this.txtbxDersAd.Visible = false;
            // 
            // txtbxDersKredi
            // 
            this.txtbxDersKredi.Location = new System.Drawing.Point(102, 184);
            this.txtbxDersKredi.Name = "txtbxDersKredi";
            this.txtbxDersKredi.Size = new System.Drawing.Size(227, 22);
            this.txtbxDersKredi.TabIndex = 17;
            this.txtbxDersKredi.Visible = false;
            // 
            // txtbxDersAkts
            // 
            this.txtbxDersAkts.Location = new System.Drawing.Point(102, 229);
            this.txtbxDersAkts.Name = "txtbxDersAkts";
            this.txtbxDersAkts.Size = new System.Drawing.Size(227, 22);
            this.txtbxDersAkts.TabIndex = 16;
            this.txtbxDersAkts.Visible = false;
            // 
            // txtbxAkademisyen
            // 
            this.txtbxAkademisyen.Location = new System.Drawing.Point(102, 287);
            this.txtbxAkademisyen.Name = "txtbxAkademisyen";
            this.txtbxAkademisyen.Size = new System.Drawing.Size(227, 22);
            this.txtbxAkademisyen.TabIndex = 15;
            this.txtbxAkademisyen.Visible = false;
            // 
            // txtbxDonemi
            // 
            this.txtbxDonemi.Location = new System.Drawing.Point(102, 337);
            this.txtbxDonemi.Name = "txtbxDonemi";
            this.txtbxDonemi.Size = new System.Drawing.Size(227, 22);
            this.txtbxDonemi.TabIndex = 14;
            this.txtbxDonemi.Visible = false;
            // 
            // lblDersDonem
            // 
            this.lblDersDonem.AutoSize = true;
            this.lblDersDonem.Location = new System.Drawing.Point(6, 343);
            this.lblDersDonem.Name = "lblDersDonem";
            this.lblDersDonem.Size = new System.Drawing.Size(86, 16);
            this.lblDersDonem.TabIndex = 11;
            this.lblDersDonem.Text = "Ders Dönemi";
            this.lblDersDonem.Visible = false;
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Location = new System.Drawing.Point(6, 235);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(65, 16);
            this.lblDersAkts.TabIndex = 9;
            this.lblDersAkts.Text = "Ders Akts";
            this.lblDersAkts.Visible = false;
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
            // btnDersGetir
            // 
            this.btnDersGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersGetir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersGetir.Location = new System.Drawing.Point(9, 71);
            this.btnDersGetir.Name = "btnDersGetir";
            this.btnDersGetir.Size = new System.Drawing.Size(320, 46);
            this.btnDersGetir.TabIndex = 0;
            this.btnDersGetir.Text = "Dersi Getir";
            this.btnDersGetir.UseVisualStyleBackColor = false;
            this.btnDersGetir.Click += new System.EventHandler(this.btnDersGetir_Click);
            // 
            // lblAkademisyenAdSoyad
            // 
            this.lblAkademisyenAdSoyad.AutoSize = true;
            this.lblAkademisyenAdSoyad.Location = new System.Drawing.Point(6, 290);
            this.lblAkademisyenAdSoyad.Name = "lblAkademisyenAdSoyad";
            this.lblAkademisyenAdSoyad.Size = new System.Drawing.Size(90, 16);
            this.lblAkademisyenAdSoyad.TabIndex = 8;
            this.lblAkademisyenAdSoyad.Text = "Akademisyen";
            this.lblAkademisyenAdSoyad.Visible = false;
            // 
            // lblDersKredi
            // 
            this.lblDersKredi.AutoSize = true;
            this.lblDersKredi.Location = new System.Drawing.Point(6, 184);
            this.lblDersKredi.Name = "lblDersKredi";
            this.lblDersKredi.Size = new System.Drawing.Size(70, 16);
            this.lblDersKredi.TabIndex = 7;
            this.lblDersKredi.Text = "Ders Kredi";
            this.lblDersKredi.Visible = false;
            // 
            // lblDersAd
            // 
            this.lblDersAd.AutoSize = true;
            this.lblDersAd.Location = new System.Drawing.Point(6, 139);
            this.lblDersAd.Name = "lblDersAd";
            this.lblDersAd.Size = new System.Drawing.Size(53, 16);
            this.lblDersAd.TabIndex = 6;
            this.lblDersAd.Text = "DersAd";
            this.lblDersAd.Visible = false;
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btniptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btniptal.Location = new System.Drawing.Point(286, 534);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(157, 48);
            this.btniptal.TabIndex = 23;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(113, 534);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(157, 48);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(137, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ders Güncelleme Formu";
            // 
            // FrmDersGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 623);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "FrmDersGuncelle";
            this.Text = "FrmDersGuncelle";
       
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.TextBox txtbxDersAd;
        private System.Windows.Forms.TextBox txtbxDersKredi;
        private System.Windows.Forms.TextBox txtbxDersAkts;
        private System.Windows.Forms.TextBox txtbxAkademisyen;
        private System.Windows.Forms.TextBox txtbxDonemi;
        private System.Windows.Forms.Label lblDersDonem;
        private System.Windows.Forms.Label lblDersAkts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDersGetir;
        private System.Windows.Forms.Label lblAkademisyenAdSoyad;
        private System.Windows.Forms.Label lblDersKredi;
        private System.Windows.Forms.Label lblDersAd;
        private System.Windows.Forms.ComboBox cmbxDersKodu;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxHarfNot;
    }
}