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
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SIPARISLER",bgl.baglanti());
            da.Fill(dt);
            gridsiparis.DataSource = dt;
        }
        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            listele();
            Urunekle();
        }
        void Urunekle()
        {
            SqlCommand komut = new SqlCommand("select URUNID from TBL_URUNLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                cmburunıd.Properties.Items.Add(dr[0]);
            }
        }

        private void cmburunıd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From TBL_URUNLER where URUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmburunıd.SelectedItem);
            SqlDataReader dataReader = komut.ExecuteReader();
            while(dataReader.Read()) 
            {
                txt_adetfiyat.Text = dataReader[3].ToString();
                txturunad.Text = dataReader[1].ToString();
            }
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtmıktar_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_adetfiyat.Text) && !string.IsNullOrEmpty(txtmıktar.Text))
            {
                int adetfiyat;
                int adet;
                if (int.TryParse(txt_adetfiyat.Text, out adetfiyat) && int.TryParse(txtmıktar.Text, out adet))
                {
                    txttoplamfıyat.Text = (adetfiyat * adet).ToString();
                }

            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into TBL_SIPARISLER (URUNID,URUNAD,ADET,TANE_FİYAT,TOPLAM_FİYAT)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Convert.ToInt32(cmburunıd.Text));
            komut.Parameters.AddWithValue("@p2", txturunad.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToInt32(txtmıktar.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToInt32(txt_adetfiyat.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToInt32(txttoplamfıyat.Text));
            komut.ExecuteNonQuery();
            MessageBox.Show("Sipariş eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
