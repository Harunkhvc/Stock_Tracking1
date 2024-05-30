namespace Stock_Tracking1
{
    partial class FrmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.gridsiparis = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lbl_urunıd = new DevExpress.XtraEditors.LabelControl();
            this.cmburunıd = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txturunad = new DevExpress.XtraEditors.TextEdit();
            this.txttoplamfıyat = new DevExpress.XtraEditors.TextEdit();
            this.txt_adetfiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtmıktar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnekle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmburunıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplamfıyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adetfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmıktar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridsiparis
            // 
            this.gridsiparis.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gridsiparis.Location = new System.Drawing.Point(45, 9);
            this.gridsiparis.MainView = this.gridView1;
            this.gridsiparis.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.gridsiparis.Name = "gridsiparis";
            this.gridsiparis.Size = new System.Drawing.Size(429, 529);
            this.gridsiparis.TabIndex = 0;
            this.gridsiparis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.gridsiparis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lbl_urunıd
            // 
            this.lbl_urunıd.Location = new System.Drawing.Point(510, 19);
            this.lbl_urunıd.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.lbl_urunıd.Name = "lbl_urunıd";
            this.lbl_urunıd.Size = new System.Drawing.Size(53, 16);
            this.lbl_urunıd.TabIndex = 1;
            this.lbl_urunıd.Text = "ÜRÜN ID:";
            // 
            // cmburunıd
            // 
            this.cmburunıd.Location = new System.Drawing.Point(583, 16);
            this.cmburunıd.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.cmburunıd.Name = "cmburunıd";
            this.cmburunıd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmburunıd.Size = new System.Drawing.Size(123, 22);
            this.cmburunıd.TabIndex = 2;
            this.cmburunıd.SelectedIndexChanged += new System.EventHandler(this.cmburunıd_SelectedIndexChanged);
            // 
            // txturunad
            // 
            this.txturunad.Location = new System.Drawing.Point(583, 61);
            this.txturunad.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.txturunad.Name = "txturunad";
            this.txturunad.Size = new System.Drawing.Size(123, 22);
            this.txturunad.TabIndex = 3;
            // 
            // txttoplamfıyat
            // 
            this.txttoplamfıyat.Location = new System.Drawing.Point(583, 197);
            this.txttoplamfıyat.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.txttoplamfıyat.Name = "txttoplamfıyat";
            this.txttoplamfıyat.Size = new System.Drawing.Size(123, 22);
            this.txttoplamfıyat.TabIndex = 4;
            // 
            // txt_adetfiyat
            // 
            this.txt_adetfiyat.Location = new System.Drawing.Point(583, 148);
            this.txt_adetfiyat.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.txt_adetfiyat.Name = "txt_adetfiyat";
            this.txt_adetfiyat.Size = new System.Drawing.Size(123, 22);
            this.txt_adetfiyat.TabIndex = 5;
            // 
            // txtmıktar
            // 
            this.txtmıktar.Location = new System.Drawing.Point(583, 105);
            this.txtmıktar.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.txtmıktar.Name = "txtmıktar";
            this.txtmıktar.Size = new System.Drawing.Size(123, 22);
            this.txtmıktar.TabIndex = 6;
            this.txtmıktar.EditValueChanged += new System.EventHandler(this.txtmıktar_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(510, 67);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Ürün Adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(513, 111);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Miktar:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(502, 151);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 16);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Adet Fiyat:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(485, 200);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Toplam Fiyat:";
            this.labelControl5.Click += new System.EventHandler(this.labelControl5_Click);
            // 
            // btnekle
            // 
            this.btnekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnekle.ImageOptions.Image")));
            this.btnekle.Location = new System.Drawing.Point(566, 267);
            this.btnekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(158, 44);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "Ekle";
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 570);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtmıktar);
            this.Controls.Add(this.txt_adetfiyat);
            this.Controls.Add(this.txttoplamfıyat);
            this.Controls.Add(this.txturunad);
            this.Controls.Add(this.cmburunıd);
            this.Controls.Add(this.lbl_urunıd);
            this.Controls.Add(this.gridsiparis);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridsiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmburunıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txturunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttoplamfıyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adetfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmıktar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridsiparis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbl_urunıd;
        private DevExpress.XtraEditors.ComboBoxEdit cmburunıd;
        private DevExpress.XtraEditors.TextEdit txturunad;
        private DevExpress.XtraEditors.TextEdit txttoplamfıyat;
        private DevExpress.XtraEditors.TextEdit txt_adetfiyat;
        private DevExpress.XtraEditors.TextEdit txtmıktar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnekle;
    }
}