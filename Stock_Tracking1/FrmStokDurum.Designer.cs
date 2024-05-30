namespace Stock_Tracking1
{
    partial class FrmStokDurum
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
            this.grid_depo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_sipars = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_sıprsgetır = new DevExpress.XtraEditors.TextEdit();
            this.btn_onay = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_sıparısıd = new DevExpress.XtraEditors.LabelControl();
            this.btn_reddet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_adetgetr = new DevExpress.XtraEditors.TextEdit();
            this.txt_urunıdgetr = new DevExpress.XtraEditors.TextEdit();
            this.lbl_urunıdsprs = new DevExpress.XtraEditors.LabelControl();
            this.lbl_siparsadet = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grid_depo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sipars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sıprsgetır.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adetgetr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunıdgetr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_depo
            // 
            this.grid_depo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grid_depo.Location = new System.Drawing.Point(0, -2);
            this.grid_depo.MainView = this.gridView1;
            this.grid_depo.Name = "grid_depo";
            this.grid_depo.Size = new System.Drawing.Size(517, 598);
            this.grid_depo.TabIndex = 0;
            this.grid_depo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_depo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grid_sipars
            // 
            this.grid_sipars.Location = new System.Drawing.Point(513, -2);
            this.grid_sipars.MainView = this.gridView2;
            this.grid_sipars.Name = "grid_sipars";
            this.grid_sipars.Size = new System.Drawing.Size(443, 598);
            this.grid_sipars.TabIndex = 1;
            this.grid_sipars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid_sipars;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView2_FocusedRowObjectChanged);
            // 
            // txt_sıprsgetır
            // 
            this.txt_sıprsgetır.Enabled = false;
            this.txt_sıprsgetır.Location = new System.Drawing.Point(1029, 98);
            this.txt_sıprsgetır.Name = "txt_sıprsgetır";
            this.txt_sıprsgetır.Size = new System.Drawing.Size(200, 22);
            this.txt_sıprsgetır.TabIndex = 2;
            // 
            // btn_onay
            // 
            this.btn_onay.Appearance.BackColor = System.Drawing.Color.Green;
            this.btn_onay.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onay.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_onay.Appearance.Options.UseBackColor = true;
            this.btn_onay.Appearance.Options.UseFont = true;
            this.btn_onay.Appearance.Options.UseForeColor = true;
            this.btn_onay.Location = new System.Drawing.Point(1165, 376);
            this.btn_onay.Name = "btn_onay";
            this.btn_onay.Size = new System.Drawing.Size(135, 42);
            this.btn_onay.TabIndex = 3;
            this.btn_onay.Text = "ONAYLA";
            this.btn_onay.Click += new System.EventHandler(this.btn_onay_Click);
            // 
            // lbl_sıparısıd
            // 
            this.lbl_sıparısıd.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sıparısıd.Appearance.Options.UseFont = true;
            this.lbl_sıparısıd.Location = new System.Drawing.Point(1029, 66);
            this.lbl_sıparısıd.Name = "lbl_sıparısıd";
            this.lbl_sıparısıd.Size = new System.Drawing.Size(122, 26);
            this.lbl_sıparısıd.TabIndex = 5;
            this.lbl_sıparısıd.Text = "SİPARİŞ ID:";
            // 
            // btn_reddet
            // 
            this.btn_reddet.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_reddet.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_reddet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_reddet.Appearance.Options.UseBackColor = true;
            this.btn_reddet.Appearance.Options.UseFont = true;
            this.btn_reddet.Appearance.Options.UseForeColor = true;
            this.btn_reddet.Location = new System.Drawing.Point(1165, 441);
            this.btn_reddet.Name = "btn_reddet";
            this.btn_reddet.Size = new System.Drawing.Size(135, 42);
            this.btn_reddet.TabIndex = 6;
            this.btn_reddet.Text = "REDDET";
            this.btn_reddet.Click += new System.EventHandler(this.btn_reddet_Click);
            // 
            // txt_adetgetr
            // 
            this.txt_adetgetr.Location = new System.Drawing.Point(1029, 183);
            this.txt_adetgetr.Name = "txt_adetgetr";
            this.txt_adetgetr.Size = new System.Drawing.Size(200, 22);
            this.txt_adetgetr.TabIndex = 7;
            // 
            // txt_urunıdgetr
            // 
            this.txt_urunıdgetr.Location = new System.Drawing.Point(1029, 266);
            this.txt_urunıdgetr.Name = "txt_urunıdgetr";
            this.txt_urunıdgetr.Size = new System.Drawing.Size(200, 22);
            this.txt_urunıdgetr.TabIndex = 8;
            // 
            // lbl_urunıdsprs
            // 
            this.lbl_urunıdsprs.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunıdsprs.Appearance.Options.UseFont = true;
            this.lbl_urunıdsprs.Location = new System.Drawing.Point(1029, 234);
            this.lbl_urunıdsprs.Name = "lbl_urunıdsprs";
            this.lbl_urunıdsprs.Size = new System.Drawing.Size(101, 26);
            this.lbl_urunıdsprs.TabIndex = 9;
            this.lbl_urunıdsprs.Text = "ÜRÜN ID:";
            // 
            // lbl_siparsadet
            // 
            this.lbl_siparsadet.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparsadet.Appearance.Options.UseFont = true;
            this.lbl_siparsadet.Location = new System.Drawing.Point(1029, 151);
            this.lbl_siparsadet.Name = "lbl_siparsadet";
            this.lbl_siparsadet.Size = new System.Drawing.Size(157, 26);
            this.lbl_siparsadet.TabIndex = 10;
            this.lbl_siparsadet.Text = "SİPARİŞ ADET:";
            // 
            // FrmStokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 601);
            this.Controls.Add(this.lbl_siparsadet);
            this.Controls.Add(this.lbl_urunıdsprs);
            this.Controls.Add(this.txt_urunıdgetr);
            this.Controls.Add(this.txt_adetgetr);
            this.Controls.Add(this.btn_reddet);
            this.Controls.Add(this.lbl_sıparısıd);
            this.Controls.Add(this.btn_onay);
            this.Controls.Add(this.txt_sıprsgetır);
            this.Controls.Add(this.grid_sipars);
            this.Controls.Add(this.grid_depo);
            this.Name = "FrmStokDurum";
            this.Text = "FrmStokDurum";
            this.Load += new System.EventHandler(this.FrmStokDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_depo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sipars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sıprsgetır.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adetgetr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunıdgetr.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_depo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grid_sipars;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit txt_sıprsgetır;
        private DevExpress.XtraEditors.SimpleButton btn_onay;
        private DevExpress.XtraEditors.LabelControl lbl_sıparısıd;
        private DevExpress.XtraEditors.SimpleButton btn_reddet;
        private DevExpress.XtraEditors.TextEdit txt_adetgetr;
        private DevExpress.XtraEditors.TextEdit txt_urunıdgetr;
        private DevExpress.XtraEditors.LabelControl lbl_urunıdsprs;
        private DevExpress.XtraEditors.LabelControl lbl_siparsadet;
    }
}