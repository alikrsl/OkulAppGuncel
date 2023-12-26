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

namespace OgretmenKayit
{
    public partial class frmOgrtmnKayit : Form
    {
        public frmOgrtmnKayit()
        {
            InitializeComponent();
        }

        private void btnOgrtmnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var ogrtblg = new OgretmenBL();
                bool sonuc = ogrtblg.OgretmenKaydet(new Ogretmen { OgretmenAd = txtOgrtmnAd.Text.Trim(), OgretmenSoyad = txtOgrtmnSoyad.Text.Trim(), OgretmenKimlikNo = txtOgretmenTc.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)  
            {
                switch(ex.Number) 
                {
                    case 2627:
                        MessageBox.Show("Bu TC numarası ile daha önce kayıt yapılmış!");
                            break;
                    default:
                        MessageBox.Show("Veritabanı Hatası!");
                        break;
                }
            }
            catch(Exception) 
            {
                throw;
                MessageBox.Show("Bilinmeyen Hata");
            }
        }
    }
}
