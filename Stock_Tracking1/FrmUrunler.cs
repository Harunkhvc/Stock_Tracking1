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

namespace Stock_Tracking1
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txt_ID.Text = "";
            txt_URUNAD.Text = "";
            txt_mıktar.Text = "";
            txt_Fıyat.Text = "";
            txt_bırım.Text = "";
            
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_dbo_StockTrackingDataSet4.TBL_URUNLER' table. You can move, or remove it, as needed.
            this.tBL_URUNLERTableAdapter.Fill(this._dbo_StockTrackingDataSet4.TBL_URUNLER);
            listele();

        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD, URUNMIKTAR,URUNFIYAT,URUNBIRIM) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_URUNAD.Text);
            komut.Parameters.AddWithValue("@p2", txt_mıktar.Text);
            komut.Parameters.AddWithValue("@p3", txt_Fıyat.Text);
            komut.Parameters.AddWithValue("@p4", txt_bırım.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
       
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_SilUrun_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_URUNLER Where URUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
