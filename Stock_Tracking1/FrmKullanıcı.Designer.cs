namespace Stock_Tracking1
{
    partial class FrmKullanıcı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanıcı));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txt_kullancsıfre = new DevExpress.XtraEditors.TextEdit();
            this.lbl_kullancsıfre = new DevExpress.XtraEditors.LabelControl();
            this.btn_Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Yetki = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Yetki = new DevExpress.XtraEditors.LabelControl();
            this.txt_Mail = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Mail = new DevExpress.XtraEditors.LabelControl();
            this.txt_Tel = new DevExpress.XtraEditors.TextEdit();
            this.txt_Tc = new DevExpress.XtraEditors.TextEdit();
            this.txt_Soyad = new DevExpress.XtraEditors.TextEdit();
            this.txt_Ad = new DevExpress.XtraEditors.TextEdit();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.lbl_Tel = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Tc = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Soyad = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Ad = new DevExpress.XtraEditors.LabelControl();
            this.lbl_ID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.tBLKULLANICILARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._dbo_StockTrackingDataSet = new Stock_Tracking1._dbo_StockTrackingDataSet();
            this.rowKULLANCID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCAD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCSOYAD = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCTC = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCTEL = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCMAIL = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowKULLANCYETKI = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.tBL_KULLANICILARTableAdapter = new Stock_Tracking1._dbo_StockTrackingDataSetTableAdapters.TBL_KULLANICILARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullancsıfre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKULLANICILARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbo_StockTrackingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(1024, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(545, 878);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txt_kullancsıfre);
            this.xtraTabPage1.Controls.Add(this.lbl_kullancsıfre);
            this.xtraTabPage1.Controls.Add(this.btn_Temizle);
            this.xtraTabPage1.Controls.Add(this.btn_Sil);
            this.xtraTabPage1.Controls.Add(this.btn_Ekle);
            this.xtraTabPage1.Controls.Add(this.txt_Yetki);
            this.xtraTabPage1.Controls.Add(this.lbl_Yetki);
            this.xtraTabPage1.Controls.Add(this.txt_Mail);
            this.xtraTabPage1.Controls.Add(this.lbl_Mail);
            this.xtraTabPage1.Controls.Add(this.txt_Tel);
            this.xtraTabPage1.Controls.Add(this.txt_Tc);
            this.xtraTabPage1.Controls.Add(this.txt_Soyad);
            this.xtraTabPage1.Controls.Add(this.txt_Ad);
            this.xtraTabPage1.Controls.Add(this.txt_ID);
            this.xtraTabPage1.Controls.Add(this.lbl_Tel);
            this.xtraTabPage1.Controls.Add(this.lbl_Tc);
            this.xtraTabPage1.Controls.Add(this.lbl_Soyad);
            this.xtraTabPage1.Controls.Add(this.lbl_Ad);
            this.xtraTabPage1.Controls.Add(this.lbl_ID);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage1.ImageOptions.Image")));
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(543, 832);
            this.xtraTabPage1.Text = "Kullanıcı Bilgisi";
            // 
            // txt_kullancsıfre
            // 
            this.txt_kullancsıfre.Location = new System.Drawing.Point(208, 331);
            this.txt_kullancsıfre.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_kullancsıfre.Name = "txt_kullancsıfre";
            this.txt_kullancsıfre.Size = new System.Drawing.Size(195, 22);
            this.txt_kullancsıfre.TabIndex = 19;
            // 
            // lbl_kullancsıfre
            // 
            this.lbl_kullancsıfre.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullancsıfre.Appearance.Options.UseFont = true;
            this.lbl_kullancsıfre.Location = new System.Drawing.Point(31, 331);
            this.lbl_kullancsıfre.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_kullancsıfre.Name = "lbl_kullancsıfre";
            this.lbl_kullancsıfre.Size = new System.Drawing.Size(38, 20);
            this.lbl_kullancsıfre.TabIndex = 18;
            this.lbl_kullancsıfre.Text = "Şifre:";
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.ImageOptions.Image")));
            this.btn_Temizle.Location = new System.Drawing.Point(338, 466);
            this.btn_Temizle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(100, 43);
            this.btn_Temizle.TabIndex = 17;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sil.ImageOptions.Image")));
            this.btn_Sil.Location = new System.Drawing.Point(191, 468);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(100, 41);
            this.btn_Sil.TabIndex = 16;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.ImageOptions.Image")));
            this.btn_Ekle.Location = new System.Drawing.Point(39, 475);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 34);
            this.btn_Ekle.TabIndex = 15;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_Yetki
            // 
            this.txt_Yetki.Location = new System.Drawing.Point(208, 374);
            this.txt_Yetki.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Yetki.Name = "txt_Yetki";
            this.txt_Yetki.Size = new System.Drawing.Size(195, 22);
            this.txt_Yetki.TabIndex = 14;
            // 
            // lbl_Yetki
            // 
            this.lbl_Yetki.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Yetki.Appearance.Options.UseFont = true;
            this.lbl_Yetki.Location = new System.Drawing.Point(31, 374);
            this.lbl_Yetki.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Yetki.Name = "lbl_Yetki";
            this.lbl_Yetki.Size = new System.Drawing.Size(43, 20);
            this.lbl_Yetki.TabIndex = 13;
            this.lbl_Yetki.Text = "Yetki:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(208, 281);
            this.txt_Mail.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(195, 22);
            this.txt_Mail.TabIndex = 12;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Mail.Appearance.Options.UseFont = true;
            this.lbl_Mail.Location = new System.Drawing.Point(31, 286);
            this.lbl_Mail.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(36, 20);
            this.lbl_Mail.TabIndex = 11;
            this.lbl_Mail.Text = "Mail:";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(208, 228);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(195, 22);
            this.txt_Tel.TabIndex = 10;
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(208, 175);
            this.txt_Tc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(195, 22);
            this.txt_Tc.TabIndex = 9;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(208, 126);
            this.txt_Soyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(195, 22);
            this.txt_Soyad.TabIndex = 8;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(208, 71);
            this.txt_Ad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(195, 22);
            this.txt_Ad.TabIndex = 7;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(208, 22);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(195, 22);
            this.txt_ID.TabIndex = 6;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tel.Appearance.Options.UseFont = true;
            this.lbl_Tel.Location = new System.Drawing.Point(31, 233);
            this.lbl_Tel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(60, 20);
            this.lbl_Tel.TabIndex = 5;
            this.lbl_Tel.Text = "Telefon:";
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tc.Appearance.Options.UseFont = true;
            this.lbl_Tc.Location = new System.Drawing.Point(39, 180);
            this.lbl_Tc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(28, 20);
            this.lbl_Tc.TabIndex = 4;
            this.lbl_Tc.Text = "TC:";
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soyad.Appearance.Options.UseFont = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(31, 130);
            this.lbl_Soyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(49, 20);
            this.lbl_Soyad.TabIndex = 3;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Appearance.Options.UseFont = true;
            this.lbl_Ad.Location = new System.Drawing.Point(37, 76);
            this.lbl_Ad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(25, 20);
            this.lbl_Ad.TabIndex = 2;
            this.lbl_Ad.Text = "Ad:";
            // 
            // lbl_ID
            // 
            this.lbl_ID.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ID.Appearance.Options.UseFont = true;
            this.lbl_ID.Location = new System.Drawing.Point(39, 27);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(23, 20);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 16);
            this.labelControl1.TabIndex = 0;
            // 
            // vGridControl1
            // 
            this.vGridControl1.BandsInterval = 1;
            this.vGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.vGridControl1.DataSource = this.tBLKULLANICILARBindingSource;
            this.vGridControl1.Location = new System.Drawing.Point(-2, 1);
            this.vGridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.OptionsView.FixedLineWidth = 1;
            this.vGridControl1.OptionsView.MinRowAutoHeight = 12;
            this.vGridControl1.RowHeaderWidth = 140;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowKULLANCID,
            this.rowKULLANCAD,
            this.rowKULLANCSOYAD,
            this.rowKULLANCTC,
            this.rowKULLANCTEL,
            this.rowKULLANCMAIL,
            this.rowKULLANCYETKI});
            this.vGridControl1.Size = new System.Drawing.Size(1026, 614);
            this.vGridControl1.TabIndex = 2;
            // 
            // tBLKULLANICILARBindingSource
            // 
            this.tBLKULLANICILARBindingSource.DataMember = "TBL_KULLANICILAR";
            this.tBLKULLANICILARBindingSource.DataSource = this._dbo_StockTrackingDataSet;
            // 
            // _dbo_StockTrackingDataSet
            // 
            this._dbo_StockTrackingDataSet.DataSetName = "_dbo_StockTrackingDataSet";
            this._dbo_StockTrackingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowKULLANCID
            // 
            this.rowKULLANCID.Name = "rowKULLANCID";
            this.rowKULLANCID.Properties.Caption = "KULLANCID";
            this.rowKULLANCID.Properties.FieldName = "KULLANCID";
            // 
            // rowKULLANCAD
            // 
            this.rowKULLANCAD.Name = "rowKULLANCAD";
            this.rowKULLANCAD.Properties.Caption = "KULLANCAD";
            this.rowKULLANCAD.Properties.FieldName = "KULLANCAD";
            // 
            // rowKULLANCSOYAD
            // 
            this.rowKULLANCSOYAD.Height = 20;
            this.rowKULLANCSOYAD.Name = "rowKULLANCSOYAD";
            this.rowKULLANCSOYAD.Properties.Caption = "KULLANCSOYAD";
            this.rowKULLANCSOYAD.Properties.FieldName = "KULLANCSOYAD";
            // 
            // rowKULLANCTC
            // 
            this.rowKULLANCTC.Name = "rowKULLANCTC";
            this.rowKULLANCTC.Properties.Caption = "KULLANCTC";
            this.rowKULLANCTC.Properties.FieldName = "KULLANCTC";
            // 
            // rowKULLANCTEL
            // 
            this.rowKULLANCTEL.Name = "rowKULLANCTEL";
            this.rowKULLANCTEL.Properties.Caption = "KULLANCTEL";
            this.rowKULLANCTEL.Properties.FieldName = "KULLANCTEL";
            // 
            // rowKULLANCMAIL
            // 
            this.rowKULLANCMAIL.Name = "rowKULLANCMAIL";
            this.rowKULLANCMAIL.Properties.Caption = "KULLANCMAIL";
            this.rowKULLANCMAIL.Properties.FieldName = "KULLANCMAIL";
            // 
            // rowKULLANCYETKI
            // 
            this.rowKULLANCYETKI.Name = "rowKULLANCYETKI";
            this.rowKULLANCYETKI.Properties.Caption = "KULLANCYETKI";
            this.rowKULLANCYETKI.Properties.FieldName = "KULLANCYETKI";
            // 
            // tBL_KULLANICILARTableAdapter
            // 
            this.tBL_KULLANICILARTableAdapter.ClearBeforeFill = true;
            // 
            // FrmKullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 626);
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKullanıcı";
            this.Text = "FrmKullanıcı";
            this.Load += new System.EventHandler(this.FrmKullanıcı_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kullancsıfre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Yetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKULLANICILARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dbo_StockTrackingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_Tc;
        private DevExpress.XtraEditors.LabelControl lbl_Soyad;
        private DevExpress.XtraEditors.LabelControl lbl_Ad;
        private DevExpress.XtraEditors.LabelControl lbl_ID;
        private DevExpress.XtraEditors.LabelControl lbl_Tel;
        private DevExpress.XtraEditors.TextEdit txt_Tel;
        private DevExpress.XtraEditors.TextEdit txt_Tc;
        private DevExpress.XtraEditors.TextEdit txt_Soyad;
        private DevExpress.XtraEditors.TextEdit txt_Ad;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.TextEdit txt_Mail;
        private DevExpress.XtraEditors.LabelControl lbl_Mail;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraEditors.TextEdit txt_Yetki;
        private DevExpress.XtraEditors.LabelControl lbl_Yetki;
        private _dbo_StockTrackingDataSet _dbo_StockTrackingDataSet;
        private System.Windows.Forms.BindingSource tBLKULLANICILARBindingSource;
        private _dbo_StockTrackingDataSetTableAdapters.TBL_KULLANICILARTableAdapter tBL_KULLANICILARTableAdapter;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCAD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCSOYAD;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCTC;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCTEL;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCMAIL;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowKULLANCYETKI;
        private DevExpress.XtraEditors.SimpleButton btn_Ekle;
        private DevExpress.XtraEditors.SimpleButton btn_Temizle;
        private DevExpress.XtraEditors.SimpleButton btn_Sil;
        private DevExpress.XtraEditors.TextEdit txt_kullancsıfre;
        private DevExpress.XtraEditors.LabelControl lbl_kullancsıfre;
    }
}