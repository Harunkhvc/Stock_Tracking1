using Stock_Tracking1;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock_Tracking1
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        Sqlbaglanti bgl = new Sqlbaglanti();

        private void btn_admıngırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT KULLANCMAIL, KULLANCSIFRE FROM TBL_KULLANICILAR WHERE KULLANCYETKI = 'admin'  AND KULLANCMAIL = @p1 AND KULLANCSIFRE = @p2;", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_maılgır.Text);
            komut.Parameters.AddWithValue("@p2", txt_sıfregır.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaSayfa frm1 = new FrmAnaSayfa();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı maili veya şifre");
                txt_maılgır.Text = "";
                txt_sıfregır.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btn_depogırıs_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT KULLANCMAIL, KULLANCSIFRE FROM TBL_KULLANICILAR WHERE KULLANCYETKI = 'Depo'  AND KULLANCMAIL = @p1 AND KULLANCSIFRE = @p2;", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_maılgır.Text);
            komut.Parameters.AddWithValue("@p2", txt_sıfregır.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmStokDurum frm5 = new FrmStokDurum();
                frm5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı maili veya şifre");
                txt_maılgır.Text = "";
                txt_sıfregır.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btn_calısan_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT KULLANCMAIL, KULLANCSIFRE FROM TBL_KULLANICILAR WHERE KULLANCYETKI = 'Bölüm Çalışanı'  AND KULLANCMAIL = @p1 AND KULLANCSIFRE = @p2;", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_maılgır.Text);
            komut.Parameters.AddWithValue("@p2", txt_sıfregır.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSiparis frm4 = new FrmSiparis();
                frm4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı maili veya şifre");
                txt_maılgır.Text = "";
                txt_sıfregır.Text = "";
            }
            bgl.baglanti().Close();
        }
    }
}
