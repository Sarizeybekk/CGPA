using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ganoHesaplama.Formlar
{
    public partial class FrmDersEkle : Form
    {
        public FrmDersEkle()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=cgpa;user Id=postgres; password=Sultan.35");
        private void btnKydt_Click(object sender, EventArgs e)
        {

            string dersKod = txtbxDersKod.Text;
            string dersAd = txtbxDersAd.Text;
            string dersKredi = txtbxDersKredi.Text;
            string dersAkts = txtbxDersAkts.Text;
            string akademisyenAdSoyad = txtbxAkademisyen.Text;
            string dersDonemi = txtbxDonemi.Text;
            string harfNotu = cmbxHarfNotu.Text;

            string ekle = "insert into ders(ders_kodu,ders_ad,ders_kredi,ders_akts,akademisyen_ad_soyad,ders_donem,harf_not) values('" +
                dersKod + "','" + dersAd + "'," + dersKredi + "," + dersAkts + ",'" + akademisyenAdSoyad + "'," + dersDonemi + ",'" + harfNotu + "')";
            try
            {
                baglanti.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(ekle, baglanti);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Ders Başarıyla eklendi");
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" Ders Eklenemedi");
                baglanti.Close();

            }


        }
    }
}
