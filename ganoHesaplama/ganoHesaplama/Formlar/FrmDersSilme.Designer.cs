namespace ganoHesaplama.Formlar
{
    partial class FrmDersSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDersSilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbxDersKodu = new System.Windows.Forms.ComboBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbxDersKodu);
            this.groupBox1.Controls.Add(this.btniptal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDersSil);
            this.groupBox1.Location = new System.Drawing.Point(115, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 438);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cmbxDersKodu
            // 
            this.cmbxDersKodu.FormattingEnabled = true;
            this.cmbxDersKodu.Location = new System.Drawing.Point(144, 129);
            this.cmbxDersKodu.Name = "cmbxDersKodu";
            this.cmbxDersKodu.Size = new System.Drawing.Size(228, 24);
            this.cmbxDersKodu.TabIndex = 24;
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btniptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btniptal.Location = new System.Drawing.Point(215, 204);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(157, 58);
            this.btniptal.TabIndex = 23;
            this.btniptal.Text = "İptal";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ders Kodu";
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.btnDersSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDersSil.Location = new System.Drawing.Point(40, 204);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(150, 58);
            this.btnDersSil.TabIndex = 0;
            this.btnDersSil.Text = "Dersi Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(85, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ders Silme Formu";
            // 
            // FrmDersSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 623);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDersSilme";
            this.Text = "FrmDersSilme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbxDersKodu;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Label label2;
    }
}