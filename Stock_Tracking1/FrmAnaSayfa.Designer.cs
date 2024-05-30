namespace Stock_Tracking1
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Anasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnKullanıcı = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Urunler = new DevExpress.XtraBars.BarButtonItem();
            this.btn_StokDurum = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TedarikciFirma = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Siparis = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Rapor = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.HomePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.applicationMenu2 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(44, 42, 44, 42);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_Anasayfa,
            this.btnKullanıcı,
            this.btn_Urunler,
            this.btn_StokDurum,
            this.btn_TedarikciFirma,
            this.btn_Siparis,
            this.btn_Rapor});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 481;
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HomePage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(1028, 108);
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.Caption = "Ana Sayfa";
            this.btn_Anasayfa.Id = 1;
            this.btn_Anasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Anasayfa.ImageOptions.Image")));
            this.btn_Anasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Anasayfa.ImageOptions.LargeImage")));
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Caption = "Kullanıcı";
            this.btnKullanıcı.Id = 2;
            this.btnKullanıcı.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcı.ImageOptions.Image")));
            this.btnKullanıcı.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKullanıcı.ImageOptions.LargeImage")));
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKullanıcı_ItemClick);
            // 
            // btn_Urunler
            // 
            this.btn_Urunler.Caption = "Ürünler";
            this.btn_Urunler.Id = 4;
            this.btn_Urunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Urunler.ImageOptions.Image")));
            this.btn_Urunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Urunler.ImageOptions.LargeImage")));
            this.btn_Urunler.Name = "btn_Urunler";
            this.btn_Urunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Urunler_ItemClick);
            // 
            // btn_StokDurum
            // 
            this.btn_StokDurum.Caption = "Stok Durum";
            this.btn_StokDurum.Id = 5;
            this.btn_StokDurum.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_StokDurum.ImageOptions.Image")));
            this.btn_StokDurum.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_StokDurum.ImageOptions.LargeImage")));
            this.btn_StokDurum.Name = "btn_StokDurum";
            this.btn_StokDurum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_StokDurum_ItemClick);
            // 
            // btn_TedarikciFirma
            // 
            this.btn_TedarikciFirma.Caption = "Tedarikçi Firma";
            this.btn_TedarikciFirma.Id = 6;
            this.btn_TedarikciFirma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TedarikciFirma.ImageOptions.Image")));
            this.btn_TedarikciFirma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TedarikciFirma.ImageOptions.LargeImage")));
            this.btn_TedarikciFirma.Name = "btn_TedarikciFirma";
            this.btn_TedarikciFirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TedarikciFirma_ItemClick);
            // 
            // btn_Siparis
            // 
            this.btn_Siparis.Caption = "Sipariş";
            this.btn_Siparis.Id = 7;
            this.btn_Siparis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Siparis.ImageOptions.Image")));
            this.btn_Siparis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Siparis.ImageOptions.LargeImage")));
            this.btn_Siparis.Name = "btn_Siparis";
            this.btn_Siparis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Siparis_ItemClick_1);
            // 
            // btn_Rapor
            // 
            this.btn_Rapor.Caption = "Rapor";
            this.btn_Rapor.Id = 8;
            this.btn_Rapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Rapor.ImageOptions.Image")));
            this.btn_Rapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Rapor.ImageOptions.LargeImage")));
            this.btn_Rapor.Name = "btn_Rapor";
            this.btn_Rapor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Rapor_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // HomePage
            // 
            this.HomePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HomePage.Name = "HomePage";
            this.HomePage.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Anasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKullanıcı);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Urunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_StokDurum);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TedarikciFirma);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Siparis);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Rapor);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // applicationMenu2
            // 
            this.applicationMenu2.Name = "applicationMenu2";
            this.applicationMenu2.Ribbon = this.ribbonControl1;
            // 
            // FrmAnaSayfa
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 572);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaSayfa";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Stock Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage HomePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_Anasayfa;
        private DevExpress.XtraBars.BarButtonItem btnKullanıcı;
        private DevExpress.XtraBars.BarButtonItem btn_Urunler;
        private DevExpress.XtraBars.BarButtonItem btn_StokDurum;
        private DevExpress.XtraBars.BarButtonItem btn_TedarikciFirma;
        private DevExpress.XtraBars.BarButtonItem btn_Siparis;
        private DevExpress.XtraBars.BarButtonItem btn_Rapor;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu2;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
    }
}

