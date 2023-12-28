using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.OkulAppSube2BLG
{
    public partial class frmOgretmenKayit : Form
    {
        public frmOgretmenKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //var ogrenci = new Ogrenci();
                //ogrenci.Ad = txtAd.Text.Trim();
                //ogrenci.Soyad = txtSoyad.Text.Trim();
                //ogrenci.Numara = txtNumara.Text.Trim();

                var obl = new OgretmenBL();
                bool sonuc = obl.OgretmenEkle(new Ogretmen { Ad = txtOgretmenAd.Text.Trim(), Soyad = txtOgretmenSoyad.Text.Trim(), TC = txtOgretmenTc.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme başarılı!" : "Ekleme başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numara daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!" + ex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
        }
    }
}
    

