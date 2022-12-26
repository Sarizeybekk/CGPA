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
    public partial class FrmDersGuncelle : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=cgpa;user Id=postgres; password=Sultan.35");
        public FrmDersGuncelle()
        {
            InitializeComponent();
            string sorgu = "Select ders_kodu  from ders order by ders_donem,ders_ad asc ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataTable ds = new DataTable();
            da.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                cmbxDersKodu.Items.Add(ds.Rows[i].ItemArray[0].ToString());

            }
            baglanti.Close();
            cmbxDersKodu.SelectedIndex = 0;

        }

        private void btnDersGetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string DersKodu = cmbxDersKodu.Items[cmbxDersKodu.SelectedIndex].ToString();
            string getir = "Select * from ders where ders_kodu='" + DersKodu + "'";
            NpgsqlCommand da = new NpgsqlCommand(getir, baglanti);
            NpgsqlDataReader reader = da.ExecuteReader();
            while (reader.Read())
            {
                txtbxDersAd.Text = reader.GetString(reader.GetOrdinal("ders_ad"));
                txtbxDersKredi.Text = reader.GetValue(reader.GetOrdinal("ders_kredi")).ToString();
                txtbxDersAkts.Text = reader.GetValue(reader.GetOrdinal("ders_akts")).ToString();
                txtbxAkademisyen.Text = reader.GetString(reader.GetOrdinal("akademisyen_ad_soyad"));
                txtbxDonemi.Text = reader.GetValue(reader.GetOrdinal("ders_donem")).ToString();
                cmbxHarfNot.Text = reader.GetString(reader.GetOrdinal("harf_not"));
                break;
            }

            txtbxDersAd.Visible = true;
            lblDersAd.Visible = true;
            txtbxDersKredi.Visible = true;
            lblDersKredi.Visible = true;
            txtbxDersAkts.Visible = true;
            lblDersAkts.Visible = true;
            txtbxAkademisyen.Visible = true;
            lblAkademisyenAdSoyad.Visible = true;
            txtbxDonemi.Visible = true;
            lblDersDonem.Visible = true;
            cmbxHarfNot.Visible = true;
            lblHarfNotu.Visible = true;
            btnGuncelle.Visible = true;
            btniptal.Visible = true;
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string DersKodu = cmbxDersKodu.Items[cmbxDersKodu.SelectedIndex].ToString();
                string dersAdi = txtbxDersAd.Text;
                string dersKredi =txtbxDersKredi.Text;
                string dersAkts = txtbxDersAkts.Text;
                string dersAkademisyen = txtbxAkademisyen.Text;
                string dersDonemi = txtbxDonemi.Text;
                string harfNotu = cmbxHarfNot.Items[cmbxHarfNot.SelectedIndex].ToString();
                //update ders set dersadi='analiz',derskredi=5 where dersKodu='bıl203'
                string sorgu = "update ders SET ders_ad = '" + dersAdi + "',ders_kredi=" + dersKredi + ",ders_akts= " + dersAkts + " ," +
                    "akademisyen_ad_soyad='" + dersAkademisyen + "', " +
                    "ders_donem=" + dersDonemi + ", harf_not= '" + harfNotu + "' WHERE ders_kodu='" + DersKodu + "'";
                NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti);

                NpgsqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show("Başarıyla guncellendi");
                baglanti.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }

        private void cmbxDersKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxDersAd.Visible = false;
            lblDersAd.Visible = false;
            txtbxDersKredi.Visible = false;
            lblDersKredi.Visible = false;
            txtbxDersAkts.Visible = false;
            lblDersAkts.Visible = false;
            txtbxAkademisyen.Visible = false;
            lblAkademisyenAdSoyad.Visible = false;
            txtbxDonemi.Visible = false;
            lblDersDonem.Visible = false;
            cmbxHarfNot.Visible = false;
            lblHarfNotu.Visible = false;
            btnGuncelle.Visible = false;
            btniptal.Visible = false;

        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
