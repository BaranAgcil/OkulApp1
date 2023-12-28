using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        private readonly string connectionString; 

        public OgretmenBL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool OgretmenEkle(Ogretmen ogretmen)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Ogretmenler VALUES (@OgretmenAd, @OgretmenSoyad, @OgretmenTc)", cn))
                {
                    cmd.Parameters.AddWithValue("@OgretmenAd", ogretmen.Ad);
                    cmd.Parameters.AddWithValue("@OgretmenSoyad", ogretmen.Soyad);
                    cmd.Parameters.AddWithValue("@OgretmenTc", ogretmen.TC);

                    try
                    {
                        cn.Open(); 

                        int rowsAffected = cmd.ExecuteNonQuery(); 

                        return rowsAffected > 0; 
                    }
                    catch (SqlException ex)
                    {
                        
                        throw new Exception("Veritabanı hatası oluştu. Hata Kodu: " + ex.Number, ex);
                    }
                    catch (Exception ex)
                    {
                        
                        throw new Exception("Bir hata oluştu: " + ex.Message, ex);
                    }
                }
            }
        }
    }
}
