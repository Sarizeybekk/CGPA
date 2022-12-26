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
    public partial class FrmDersSilme : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=cgpa;user Id=postgres; password=Sultan.35");
        public FrmDersSilme()
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

        private void btnDersSil_Click(object sender, EventArgs e)
        {
       
            try
            {
                baglanti.Open();
                string DersKodu = cmbxDersKodu.Items[cmbxDersKodu.SelectedIndex].ToString();
                string sorguSil = "DELETE FROM ders WHERE ders_kodu='" + DersKodu + "'";
                NpgsqlCommand command = new NpgsqlCommand(sorguSil, baglanti);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                MessageBox.Show(" Ders başarıyla silindi");
                cmbxDersKodu.Items.Remove(DersKodu);
                cmbxDersKodu.SelectedIndex = 0;
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(" Ders silinemedi");

            }
           
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
