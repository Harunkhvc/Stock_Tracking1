using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Stock_Tracking1
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        Sqlbaglanti bgl = new Sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SIPARISLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt; 

        }
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            listele();
        }
    }

}

