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
    public partial class FrmTranskript : Form
    {
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432;Database=cgpa;user Id=postgres; password=Sultan.35");
        public FrmTranskript()
        {
            InitializeComponent();
            string sorgu = "Select ders_kodu,ders_ad,ders_kredi,ders_akts,akademisyen_ad_soyad,ders_donem,harf_not from ders WHERE harf_not !='' order by ders_donem,ders_ad asc ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            double[] krediArray = new double[8];
            double[] notArray = new double[8];
            double krediToplam = 0;
            double notToplam = 0;
            int donem;

            foreach (DataRow item in ds.Tables[0].Rows)
            {
                donem = Int32.Parse(item["ders_donem"].ToString());
                krediArray[donem - 1] += double.Parse(item["ders_kredi"].ToString());

                krediToplam += double.Parse(item["ders_kredi"].ToString());
                switch (item["harf_not"].ToString())
                {
                    case "AA":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 4;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 4;
                        break;
                    case "BA":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 3.5;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 3.5;
                        break;
                    case "BB":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 3;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 3;
                        break;
                    case "CB":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 2.5;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 2.5;
                        break;
                    case "CC":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 2;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 2;
                        break;
                    case "DC":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 1.5;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 1.5;
                        break;
                    case "DD":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 1;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 1;
                        break;
                    case "FD":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 0.5;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 0.5;
                        break;
                    case "FF":
                        notToplam += double.Parse(item["ders_kredi"].ToString()) * 0;
                        notArray[donem - 1] += double.Parse(item["ders_kredi"].ToString()) * 0;
                        break;

                }

            }
            txtbxGano.Text = (notToplam / krediToplam).ToString("#.##");
            lbl1.Text += " : " + (krediArray[0] == 0 ? "0" : (notArray[0] / krediArray[0]).ToString("#.##"));
            lbl2.Text += " : " + (krediArray[1] == 0 ? "0" : (notArray[1] / krediArray[1]).ToString("#.##"));
            lbl3.Text += " : " + (krediArray[2] == 0 ? "0" : (notArray[2] / krediArray[2]).ToString("#.##"));
            lbl4.Text += " : " + (krediArray[3] == 0 ? "0" : (notArray[3] / krediArray[3]).ToString("#.##"));
            lbl5.Text += " : " + (krediArray[4] == 0 ? "0" : (notArray[4] / krediArray[4]).ToString("#.##"));
            lbl6.Text += " : " + (krediArray[5] == 0 ? "0" : (notArray[5] / krediArray[5]).ToString("#.##"));
            lbl7.Text += " : " + (krediArray[6] == 0 ? "0" : (notArray[6] / krediArray[6]).ToString("#.##"));
            lbl8.Text += " : " + (krediArray[7] == 0 ? "0" : (notArray[7] / krediArray[7]).ToString("#.##"));




        }


    }
}
