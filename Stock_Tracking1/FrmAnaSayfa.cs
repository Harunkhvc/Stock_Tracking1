using Stock_Tracking1;

namespace Stock_Tracking1
{
    public partial class FrmAnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        FrmKullanıcı frm1;
        FrmTedarkci frm2;
        FrmUrunler frm3;
        FrmSiparis frm4;
        FrmStokDurum frm5;
        FrmRapor frm6;
        private void btnKullanıcı_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null)
            {
                frm1 = new FrmKullanıcı();
                frm1.MdiParent = this;
                frm1.Show();
            }


        }

        private void btn_TedarikciFirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new FrmTedarkci();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }

        private void btn_Urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new FrmUrunler();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void btn_StokDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null)
            {
                frm5 = new FrmStokDurum();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void btn_Rapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null)
            {
                frm6 = new FrmRapor();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }

        private void btn_Siparis_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null)
            {
                frm4 = new FrmSiparis();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
    }

}
