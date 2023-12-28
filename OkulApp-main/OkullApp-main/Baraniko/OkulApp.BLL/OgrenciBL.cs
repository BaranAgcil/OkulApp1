using DAL;
using OkulApp.MODEL;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace OkulApp.BLL//Bussiness Logic Layer
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@OgrenciAd",ogr.Ad),
                                  new SqlParameter("@OgrenciSoyad",ogr.Soyad),
                                  new SqlParameter("@OgrenciNo",ogr.Numara)
                            };

                var hlp = new Helper();
                return hlp.ExecuteNonQuery("Insert into Ogrenciler  values (@OgrenciAd,@OgrenciSoyad,@OgrenciNo)", p) > 0;
            }
            catch (SqlException ex )
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //if (cn != null && cn.State != ConnectionState.Closed)
                // {
                //     cn.Close();
                //    cn.Dispose();

                //    cmd.Dispose();
                //}
            }
        }


    }
}
