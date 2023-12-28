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
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

       
        //Dispose
        //Garbage Collector
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //var ogrenci = new Ogrenci();
                //ogrenci.Ad = txtAd.Text.Trim();
                //ogrenci.Soyad = txtSoyad.Text.Trim();
                //ogrenci.Numara = txtNumara.Text.Trim();

                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
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
                        MessageBox.Show("Veritabanı Hatası!"+ex.Message);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!!");
            }
        }
    }

    //interface ITransfer
    //{
    //    int EFT(string aliciiban, string gondereniban, double tutar);
    //    int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih);
    //}

    //class TransferIslemleri : ITransfer
    //{
    //    public int EFT(string aliciiban, string gondereniban, double tutar)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Havale(string aliciiban, string gondereniban, double tutar, DateTime tarih)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

//n Katmanlı Mimari
