using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Stock_Tracking1
{
    public partial class FrmStokDurum : Form
    {
        public FrmStokDurum()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt1 = new DataTable();
            using (SqlConnection connection = bgl.baglanti())
            {
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT URUNID,URUNAD,URUNMIKTAR FROM TBL_URUNLER", connection);
                da1.Fill(dt1);
            }
            grid_depo.DataSource = dt1;

            DataTable dt2 = new DataTable();
            using (SqlConnection connection = bgl.baglanti())
            {
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_SIPARISLER ", connection);
                da2.Fill(dt2);
            }
            grid_sipars.DataSource = dt2;

        }


        private void FrmStokDurum_Load(object sender, System.EventArgs e)
        {
            listele();
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                txt_sıprsgetır.Text = dr["SIPARISID"].ToString();
                txt_adetgetr.Text = dr["ADET"].ToString();
                txt_urunıdgetr.Text = dr["URUNID"].ToString();

            }
        }

        private void btn_onay_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_URUNLER Set URUNMIKTAR=URUNMIKTAR-@p1 where URUNID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_adetgetr.Text));
            komut.Parameters.AddWithValue("@p2", Convert.ToInt32(txt_urunıdgetr.Text));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Birime Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            SqlCommand komut1 = new SqlCommand("delete from TBL_SIPARISLER where SIPARISID =@p1 ",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_sıprsgetır.Text));
            komut1.ExecuteNonQuery();
            bgl.baglanti() .Close();    
            listele();
        }

        private void btn_reddet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("delete from TBL_SIPARISLER where SIPARISID =@p1 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(txt_sıprsgetır.Text));
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sipariş Reddedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
