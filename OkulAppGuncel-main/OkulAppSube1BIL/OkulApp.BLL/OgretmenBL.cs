using DAL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Data.SqlClient;

namespace OkulApp.BLL
{
    public class OgretmenBL
    {
        public bool OgretmenKaydet(Ogretmen ogrtmn)
        {
            
            SqlParameter[] p =
            {
                new SqlParameter("@Ad", ogrtmn.OgretmenAd),
                new SqlParameter("@Soyad", ogrtmn.OgretmenSoyad),
                new SqlParameter("@KimlikNo", ogrtmn.OgretmenKimlikNo)
            };
            Helper hlp = new Helper();
            return hlp.ExecuteNonQuery("Insert into tblOgretmenler values (@Ad, @Soyad, @KimlikNo)", p) > 0;
        }
    }
}
