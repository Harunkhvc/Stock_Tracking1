using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid;

namespace Stock_Tracking1
{
    public partial class FrmKullanıcı : Form
    {
        public FrmKullanıcı()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_KULLANICILAR", bgl.baglanti());
            da.Fill(dt);
            vGridControl1.DataSource = dt;
        }
        void temizle()
        {
            txt_ID.Text = "";
            txt_Ad.Text = "";
            txt_Soyad.Text = "";
            txt_Tc.Text = "";
            txt_Tel.Text = "";
            txt_Yetki.Text = "";
            txt_Mail.Text = "";
            txt_kullancsıfre.Text = "";

        }
        private void FrmKullanıcı_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmKullanıcı_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_dbo_StockTrackingDataSet.TBL_KULLANICILAR' table. You can move, or remove it, as needed.
            this.tBL_KULLANICILARTableAdapter.Fill(this._dbo_StockTrackingDataSet.TBL_KULLANICILAR);

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_KULLANICILAR (KULLANCAD, KULLANCSOYAD,KULLANCTC,KULLANCTEL,KULLANCMAIL,KULLANCSIFRE,KULLANCYETKI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@p3", txt_Tc.Text);
            komut.Parameters.AddWithValue("@p4", txt_Tel.Text);
            komut.Parameters.AddWithValue("@p5", txt_Mail.Text);
            komut.Parameters.AddWithValue("@p6", txt_kullancsıfre.Text);
            komut.Parameters.AddWithValue("@p7", txt_Yetki.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            string yetki = txt_Yetki.Text;
            if (yetki=="Admin" )
            {
                MessageBox.Show("Admin olarak giriş yapılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_KULLANICILAR Where KULLANCID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        //private void vGridControl1_FocusedRowChanged(object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e)
        //{
        //    DataRow dr = vGridControl1.GetDataRow(vGridControl1.FocusedRowChanged);
        //    if (dr != null)
        //    {
        //        txt_ID.Text = dr["TEDARIKID"].ToString();
        //        txt_Ad.Text = dr["TEDARIKAD"].ToString();
        //        txt_Kategori.Text = dr["TEDARIKKATEGORI"].ToString();
        //        txt_Tel.Text = dr["TEDARIKTEL"].ToString();
        //    }
        //}
    }
}
