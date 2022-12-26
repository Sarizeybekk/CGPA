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
    public partial class FrmDersListesi : Form
    {
      
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=cgpa;user Id=postgres; password=Sultan.35");
        public FrmDersListesi()
        {
            InitializeComponent();
            string sorgu = "Select ders_kodu,ders_ad,ders_kredi,ders_akts,akademisyen_ad_soyad,ders_donem,harf_not from ders order by ders_donem,ders_ad asc ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

      

     
    }
}
