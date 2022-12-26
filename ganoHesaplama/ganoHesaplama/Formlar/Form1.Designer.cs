namespace ganoHesaplama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDersLst = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDersLst
            // 
            this.btnDersLst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersLst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersLst.Location = new System.Drawing.Point(596, 40);
            this.btnDersLst.Name = "btnDersLst";
            this.btnDersLst.Size = new System.Drawing.Size(157, 65);
            this.btnDersLst.TabIndex = 0;
            this.btnDersLst.Text = "Ders Listele";
            this.btnDersLst.UseVisualStyleBackColor = false;
            this.btnDersLst.Click += new System.EventHandler(this.btnDersLst_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersEkle.Location = new System.Drawing.Point(596, 125);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(157, 65);
            this.btnDersEkle.TabIndex = 1;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersSil.Location = new System.Drawing.Point(596, 292);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(157, 65);
            this.btnDersSil.TabIndex = 2;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersGuncelle.Location = new System.Drawing.Point(596, 208);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(157, 65);
            this.btnDersGuncelle.TabIndex = 3;
            this.btnDersGuncelle.Text = "Ders Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = false;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnTranskript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTranskript.Location = new System.Drawing.Point(596, 375);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(157, 65);
            this.btnTranskript.TabIndex = 4;
            this.btnTranskript.Text = "Transkript ";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 523);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnDersGuncelle);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Controls.Add(this.btnDersLst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersLst;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnTranskript;
    }
}

