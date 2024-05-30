namespace Stock_Tracking1
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._dbo_StockTrackingDataSet4 = new Stock_Tracking1._dbo_StockTrackingDataSet4();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colURUNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNBIRIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SilUrun = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Fıyat = new DevExpress.XtraEditors.TextEdit();
            this.txt_URUNAD = new DevExpress.XtraEditors.TextEdit();
            this.txt_mıktar = new DevExpress.XtraEditors.TextEdit();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Bırım = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Fıyat = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Mıktar = new DevExpress.XtraEditors.LabelControl();
            this.lbl_UrunAd = new DevExpress.XtraEditors.LabelControl();
            this.lbl_URUNID = new DevExpress.XtraEditors.LabelControl();
            this.txt_bırım = new DevExpress.XtraEditors.TextEdit();
            this.tBL_URUNLERTableAdapter = new Stock_Tracking1._dbo_StockTrackingDataSet4TableAdapters.TBL_URUNLERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbo_StockTrackingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fıyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_URUNAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mıktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bırım.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tBLURUNLERBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-1, 0);
            this.gridControl1.MainView = this.gridView7;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(731, 532);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // tBLURUNLERBindingSource
            // 
            this.tBLURUNLERBindingSource.DataMember = "TBL_URUNLER";
            this.tBLURUNLERBindingSource.DataSource = this._dbo_StockTrackingDataSet4;
            // 
            // _dbo_StockTrackingDataSet4
            // 
            this._dbo_StockTrackingDataSet4.DataSetName = "_dbo_StockTrackingDataSet4";
            this._dbo_StockTrackingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colURUNID,
            this.colURUNAD,
            this.colURUNMIKTAR,
            this.colURUNFIYAT,
            this.colURUNBIRIM});
            this.gridView7.GridControl = this.gridControl1;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colURUNID
            // 
            this.colURUNID.FieldName = "URUNID";
            this.colURUNID.MinWidth = 25;
            this.colURUNID.Name = "colURUNID";
            this.colURUNID.Visible = true;
            this.colURUNID.VisibleIndex = 0;
            this.colURUNID.Width = 94;
            // 
            // colURUNAD
            // 
            this.colURUNAD.FieldName = "URUNAD";
            this.colURUNAD.MinWidth = 25;
            this.colURUNAD.Name = "colURUNAD";
            this.colURUNAD.Visible = true;
            this.colURUNAD.VisibleIndex = 1;
            this.colURUNAD.Width = 94;
            // 
            // colURUNMIKTAR
            // 
            this.colURUNMIKTAR.FieldName = "URUNMIKTAR";
            this.colURUNMIKTAR.MinWidth = 25;
            this.colURUNMIKTAR.Name = "colURUNMIKTAR";
            this.colURUNMIKTAR.Visible = true;
            this.colURUNMIKTAR.VisibleIndex = 2;
            this.colURUNMIKTAR.Width = 94;
            // 
            // colURUNFIYAT
            // 
            this.colURUNFIYAT.FieldName = "URUNFIYAT";
            this.colURUNFIYAT.MinWidth = 25;
            this.colURUNFIYAT.Name = "colURUNFIYAT";
            this.colURUNFIYAT.Visible = true;
            this.colURUNFIYAT.VisibleIndex = 3;
            this.colURUNFIYAT.Width = 94;
            // 
            // colURUNBIRIM
            // 
            this.colURUNBIRIM.FieldName = "URUNBIRIM";
            this.colURUNBIRIM.MinWidth = 25;
            this.colURUNBIRIM.Name = "colURUNBIRIM";
            this.colURUNBIRIM.Visible = true;
            this.colURUNBIRIM.VisibleIndex = 4;
            this.colURUNBIRIM.Width = 94;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(732, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(353, 532);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btn_Temizle);
            this.xtraTabPage1.Controls.Add(this.btn_SilUrun);
            this.xtraTabPage1.Controls.Add(this.btn_UrunEkle);
            this.xtraTabPage1.Controls.Add(this.txt_Fıyat);
            this.xtraTabPage1.Controls.Add(this.txt_URUNAD);
            this.xtraTabPage1.Controls.Add(this.txt_mıktar);
            this.xtraTabPage1.Controls.Add(this.txt_ID);
            this.xtraTabPage1.Controls.Add(this.lbl_Bırım);
            this.xtraTabPage1.Controls.Add(this.lbl_Fıyat);
            this.xtraTabPage1.Controls.Add(this.lbl_Mıktar);
            this.xtraTabPage1.Controls.Add(this.lbl_UrunAd);
            this.xtraTabPage1.Controls.Add(this.lbl_URUNID);
            this.xtraTabPage1.Controls.Add(this.txt_bırım);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(351, 486);
            this.xtraTabPage1.Text = "Ürünler";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.ImageOptions.Image")));
            this.btn_Temizle.Location = new System.Drawing.Point(224, 371);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(94, 29);
            this.btn_Temizle.TabIndex = 17;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_SilUrun
            // 
            this.btn_SilUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SilUrun.ImageOptions.Image")));
            this.btn_SilUrun.Location = new System.Drawing.Point(224, 324);
            this.btn_SilUrun.Name = "btn_SilUrun";
            this.btn_SilUrun.Size = new System.Drawing.Size(94, 29);
            this.btn_SilUrun.TabIndex = 16;
            this.btn_SilUrun.Text = "Sil";
            this.btn_SilUrun.Click += new System.EventHandler(this.btn_SilUrun_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunEkle.ImageOptions.Image")));
            this.btn_UrunEkle.Location = new System.Drawing.Point(224, 278);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(94, 29);
            this.btn_UrunEkle.TabIndex = 15;
            this.btn_UrunEkle.Text = "Ekle";
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // txt_Fıyat
            // 
            this.txt_Fıyat.Location = new System.Drawing.Point(183, 177);
            this.txt_Fıyat.Name = "txt_Fıyat";
            this.txt_Fıyat.Size = new System.Drawing.Size(125, 22);
            this.txt_Fıyat.TabIndex = 10;
            // 
            // txt_URUNAD
            // 
            this.txt_URUNAD.Location = new System.Drawing.Point(183, 95);
            this.txt_URUNAD.Name = "txt_URUNAD";
            this.txt_URUNAD.Size = new System.Drawing.Size(125, 22);
            this.txt_URUNAD.TabIndex = 9;
            // 
            // txt_mıktar
            // 
            this.txt_mıktar.Location = new System.Drawing.Point(183, 132);
            this.txt_mıktar.Name = "txt_mıktar";
            this.txt_mıktar.Size = new System.Drawing.Size(125, 22);
            this.txt_mıktar.TabIndex = 8;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(183, 54);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(125, 22);
            this.txt_ID.TabIndex = 5;
            // 
            // lbl_Bırım
            // 
            this.lbl_Bırım.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Bırım.Appearance.Options.UseFont = true;
            this.lbl_Bırım.Location = new System.Drawing.Point(27, 220);
            this.lbl_Bırım.Name = "lbl_Bırım";
            this.lbl_Bırım.Size = new System.Drawing.Size(86, 20);
            this.lbl_Bırım.TabIndex = 4;
            this.lbl_Bırım.Text = "Ürün Birim:";
            // 
            // lbl_Fıyat
            // 
            this.lbl_Fıyat.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fıyat.Appearance.Options.UseFont = true;
            this.lbl_Fıyat.Location = new System.Drawing.Point(27, 179);
            this.lbl_Fıyat.Name = "lbl_Fıyat";
            this.lbl_Fıyat.Size = new System.Drawing.Size(40, 20);
            this.lbl_Fıyat.TabIndex = 3;
            this.lbl_Fıyat.Text = "Fiyat:";
            // 
            // lbl_Mıktar
            // 
            this.lbl_Mıktar.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mıktar.Appearance.Options.UseFont = true;
            this.lbl_Mıktar.Location = new System.Drawing.Point(27, 135);
            this.lbl_Mıktar.Name = "lbl_Mıktar";
            this.lbl_Mıktar.Size = new System.Drawing.Size(52, 20);
            this.lbl_Mıktar.TabIndex = 2;
            this.lbl_Mıktar.Text = "Miktar:";
            // 
            // lbl_UrunAd
            // 
            this.lbl_UrunAd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UrunAd.Appearance.Options.UseFont = true;
            this.lbl_UrunAd.Location = new System.Drawing.Point(27, 98);
            this.lbl_UrunAd.Name = "lbl_UrunAd";
            this.lbl_UrunAd.Size = new System.Drawing.Size(71, 20);
            this.lbl_UrunAd.TabIndex = 1;
            this.lbl_UrunAd.Text = "Ürün Adı:";
            // 
            // lbl_URUNID
            // 
            this.lbl_URUNID.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_URUNID.Appearance.Options.UseFont = true;
            this.lbl_URUNID.Location = new System.Drawing.Point(27, 54);
            this.lbl_URUNID.Name = "lbl_URUNID";
            this.lbl_URUNID.Size = new System.Drawing.Size(23, 20);
            this.lbl_URUNID.TabIndex = 0;
            this.lbl_URUNID.Text = "ID:";
            // 
            // txt_bırım
            // 
            this.txt_bırım.EditValue = "";
            this.txt_bırım.Location = new System.Drawing.Point(183, 220);
            this.txt_bırım.Name = "txt_bırım";
            this.txt_bırım.Size = new System.Drawing.Size(125, 22);
            this.txt_bırım.TabIndex = 11;
            // 
            // tBL_URUNLERTableAdapter
            // 
            this.tBL_URUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 531);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbo_StockTrackingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fıyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_URUNAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mıktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bırım.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl lbl_Fıyat;
        private DevExpress.XtraEditors.LabelControl lbl_Mıktar;
        private DevExpress.XtraEditors.LabelControl lbl_UrunAd;
        private DevExpress.XtraEditors.LabelControl lbl_URUNID;
        private DevExpress.XtraEditors.TextEdit txt_Fıyat;
        private DevExpress.XtraEditors.TextEdit txt_URUNAD;
        private DevExpress.XtraEditors.TextEdit txt_mıktar;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.LabelControl lbl_Bırım;
        private _dbo_StockTrackingDataSet4 _dbo_StockTrackingDataSet4;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource;
        private _dbo_StockTrackingDataSet4TableAdapters.TBL_URUNLERTableAdapter tBL_URUNLERTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNID;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNBIRIM;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton btn_SilUrun;
        private DevExpress.XtraEditors.SimpleButton btn_UrunEkle;
        private DevExpress.XtraEditors.TextEdit txt_bırım;
    }
}