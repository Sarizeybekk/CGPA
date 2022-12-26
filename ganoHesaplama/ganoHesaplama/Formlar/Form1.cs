using ganoHesaplama.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ganoHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDersLst_Click(object sender, EventArgs e)
        {
            FrmDersListesi frmDersListesi= new FrmDersListesi();
            frmDersListesi.ShowDialog();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            FrmDersEkle frmDersEkle = new FrmDersEkle();
            frmDersEkle.ShowDialog();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            FrmDersGuncelle frmDersGuncelle = new FrmDersGuncelle();
            frmDersGuncelle.ShowDialog();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
          FrmDersSilme frmDersSilme= new FrmDersSilme();
            frmDersSilme.ShowDialog();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            FrmTranskript frmTranskript= new FrmTranskript();
            frmTranskript.ShowDialog();
        }
    }
}
