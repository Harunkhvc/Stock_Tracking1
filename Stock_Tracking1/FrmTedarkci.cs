using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock_Tracking1
{ 
    public partial class FrmTedarkci : Form
    {
        public FrmTedarkci()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();

        void listele()
        {
            DataTable dt1 = new DataTable();
            using (SqlConnection connection = bgl.baglanti())
            {
                SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM TBL_TEDARIKCI WHERE TEDARIKKATEGORI='TEKNOLOJİ'", connection);
                da1.Fill(dt1);
            }
            gridControl4.DataSource= dt1;

            DataTable dt2 = new DataTable();
            using (SqlConnection connection = bgl.baglanti())
            {
                SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBL_TEDARIKCI WHERE TEDARIKKATEGORI='GIDA'", connection);
                da2.Fill(dt2);
            }
            gridControl2.DataSource = dt2;

            DataTable dt3 = new DataTable();
            using (SqlConnection connection = bgl.baglanti())
            {
                SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM TBL_TEDARIKCI WHERE TEDARIKKATEGORI='HAZIR ÜRÜN'", connection);
                da3.Fill(dt3);
            }
            gridControl3.DataSource = dt3;
        }

        void temizle()
        {
            txt_ID.Text = string.Empty;
            txt_Ad.Text = string.Empty;
            txt_Kategori.Text = string.Empty;
            txt_Tel.Text = string.Empty;
        }

        private void FrmTedarkci_Load(object sender, EventArgs e)
        {
            this.tBL_TEDARIKCITableAdapter1.Fill(this._dbo_StockTrackingDataSet5.TBL_TEDARIKCI);
            this.tBL_TEDARIKCITableAdapter.Fill(this._dbo_StockTrackingDataSet1.TBL_TEDARIKCI);
            listele();
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["TEDARIKID"].ToString();
                txt_Ad.Text = dr["TEDARIKAD"].ToString();
                txt_Kategori.Text = dr["TEDARIKKATEGORI"].ToString();
                txt_Tel.Text = dr["TEDARIKTEL"].ToString();
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = grid_gıda.GetDataRow(grid_gıda.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["TEDARIKID"].ToString();
                txt_Ad.Text = dr["TEDARIKAD"].ToString();
                txt_Kategori.Text = dr["TEDARIKKATEGORI"].ToString();
                txt_Tel.Text = dr["TEDARIKTEL"].ToString();
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = grid_hazırurun.GetDataRow(grid_hazırurun.FocusedRowHandle);
            if (dr != null)
            {
                txt_ID.Text = dr["TEDARIKID"].ToString();
                txt_Ad.Text = dr["TEDARIKAD"].ToString();
                txt_Kategori.Text = dr["TEDARIKKATEGORI"].ToString();
                txt_Tel.Text = dr["TEDARIKTEL"].ToString();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = bgl.baglanti())
            {
                //connection.Open();

                using (SqlCommand komut = new SqlCommand("INSERT INTO TBL_TEDARIKCI (TEDARIKAD, TEDARIKKATEGORI, TEDARIKTEL) VALUES (@p1, @p2, @p3)", bgl.baglanti()))
                {
                    komut.Parameters.AddWithValue("@p1", txt_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Kategori.Text);
                    komut.Parameters.AddWithValue("@p3", txt_Tel.Text);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
               
                // Bağlantı burada otomatik olarak kapatılacaktır.
            }

            MessageBox.Show("Firma Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = bgl.baglanti())
            {

                using (SqlCommand komut = new SqlCommand("DELETE FROM TBL_TEDARIKCI WHERE TEDARIKID=@p1", bgl.baglanti()))
                {
                    komut.Parameters.AddWithValue("@p1", txt_ID.Text);
                    komut.ExecuteNonQuery();
                    
                }
            }

            MessageBox.Show("Firma Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
    

