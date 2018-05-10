namespace QLTTTA.GUI
{
   partial class frmDSTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuTK = new DevExpress.XtraBars.BarButtonItem();
            this.btnLammoiTK = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbGiangVien = new System.Windows.Forms.RadioButton();
            this.edtXacNhanMK = new DevExpress.XtraEditors.TextEdit();
            this.edtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.edtMail = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtXacNhanMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemTK,
            this.btnXoaTK,
            this.btnSuaTK,
            this.btnLuuTK,
            this.btnLammoiTK,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLammoiTK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemTK
            // 
            this.btnThemTK.Caption = "Thêm";
            this.btnThemTK.Id = 0;
            this.btnThemTK.ImageOptions.Image = global::QLTTTA.Properties.Resources.add;
            this.btnThemTK.ImageOptions.LargeImage = global::QLTTTA.Properties.Resources.add;
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTK_ItemClick);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.Caption = "Sửa";
            this.btnSuaTK.Id = 2;
            this.btnSuaTK.ImageOptions.Image = global::QLTTTA.Properties.Resources.Pencil_icon;
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaTK_ItemClick);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Caption = "Xóa";
            this.btnXoaTK.Id = 1;
            this.btnXoaTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.ImageOptions.Image")));
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTK_ItemClick);
            // 
            // btnLuuTK
            // 
            this.btnLuuTK.Caption = "Lưu lại";
            this.btnLuuTK.Id = 3;
            this.btnLuuTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTK.ImageOptions.Image")));
            this.btnLuuTK.Name = "btnLuuTK";
            this.btnLuuTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuTK_ItemClick);
            // 
            // btnLammoiTK
            // 
            this.btnLammoiTK.Caption = "Làm mới";
            this.btnLammoiTK.Id = 4;
            this.btnLammoiTK.ImageOptions.Image = global::QLTTTA.Properties.Resources.refresh;
            this.btnLammoiTK.Name = "btnLammoiTK";
            this.btnLammoiTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLammoiTK_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(647, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 433);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(647, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 383);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(647, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 383);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rdbAdmin);
            this.layoutControl1.Controls.Add(this.rdbGiangVien);
            this.layoutControl1.Controls.Add(this.edtXacNhanMK);
            this.layoutControl1.Controls.Add(this.edtMatKhau);
            this.layoutControl1.Controls.Add(this.edtMail);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 50);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(766, 41, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(647, 148);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.Enabled = false;
            this.rdbAdmin.Location = new System.Drawing.Point(326, 100);
            this.rdbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(305, 31);
            this.rdbAdmin.TabIndex = 9;
            this.rdbAdmin.Text = "Nhân viên quản lý";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbGiangVien
            // 
            this.rdbGiangVien.Checked = true;
            this.rdbGiangVien.Enabled = false;
            this.rdbGiangVien.Location = new System.Drawing.Point(16, 100);
            this.rdbGiangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbGiangVien.Name = "rdbGiangVien";
            this.rdbGiangVien.Size = new System.Drawing.Size(304, 31);
            this.rdbGiangVien.TabIndex = 8;
            this.rdbGiangVien.TabStop = true;
            this.rdbGiangVien.Text = "Giảng viên";
            this.rdbGiangVien.UseVisualStyleBackColor = true;
            // 
            // edtXacNhanMK
            // 
            this.edtXacNhanMK.Enabled = false;
            this.edtXacNhanMK.Location = new System.Drawing.Point(138, 72);
            this.edtXacNhanMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtXacNhanMK.MenuManager = this.barManager1;
            this.edtXacNhanMK.Name = "edtXacNhanMK";
            this.edtXacNhanMK.Size = new System.Drawing.Size(493, 22);
            this.edtXacNhanMK.StyleController = this.layoutControl1;
            this.edtXacNhanMK.TabIndex = 7;
            // 
            // edtMatKhau
            // 
            this.edtMatKhau.Enabled = false;
            this.edtMatKhau.Location = new System.Drawing.Point(138, 44);
            this.edtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtMatKhau.MenuManager = this.barManager1;
            this.edtMatKhau.Name = "edtMatKhau";
            this.edtMatKhau.Size = new System.Drawing.Size(493, 22);
            this.edtMatKhau.StyleController = this.layoutControl1;
            this.edtMatKhau.TabIndex = 6;
            // 
            // edtMail
            // 
            this.edtMail.Enabled = false;
            this.edtMail.Location = new System.Drawing.Point(138, 16);
            this.edtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.edtMail.MenuManager = this.barManager1;
            this.edtMail.Name = "edtMail";
            this.edtMail.Size = new System.Drawing.Size(493, 22);
            this.edtMail.StyleController = this.layoutControl1;
            this.edtMail.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(647, 148);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.edtMail;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem1.Text = "Mail";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(119, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.edtMatKhau;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem3.Text = "Mật khẩu";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.edtXacNhanMK;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(621, 28);
            this.layoutControlItem4.Text = "Xác nhận mật khẩu";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(119, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.rdbGiangVien;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(310, 38);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.rdbAdmin;
            this.layoutControlItem6.Location = new System.Drawing.Point(310, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(311, 38);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // gcTaiKhoan
            // 
            this.gcTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaiKhoan.Location = new System.Drawing.Point(0, 198);
            this.gcTaiKhoan.MainView = this.gridView1;
            this.gcTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaiKhoan.MenuManager = this.barManager1;
            this.gcTaiKhoan.Name = "gcTaiKhoan";
            this.gcTaiKhoan.Size = new System.Drawing.Size(647, 235);
            this.gcTaiKhoan.TabIndex = 5;
            this.gcTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gcTaiKhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mail";
            this.gridColumn1.FieldName = "Mail";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mật khẩu";
            this.gridColumn2.FieldName = "MatKhau";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Quyền đăng nhập";
            this.gridColumn3.FieldName = "QuyenDangNhap";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // frmDSTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 433);
            this.Controls.Add(this.gcTaiKhoan);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDSTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách tài khoản";
            this.Load += new System.EventHandler(this.frmDSTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtXacNhanMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem btnThemTK;
      private DevExpress.XtraBars.BarButtonItem btnXoaTK;
      private DevExpress.XtraBars.BarButtonItem btnSuaTK;
      private DevExpress.XtraBars.BarButtonItem btnLuuTK;
      private DevExpress.XtraBars.BarButtonItem btnLammoiTK;
      private DevExpress.XtraGrid.GridControl gcTaiKhoan;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit edtXacNhanMK;
      private DevExpress.XtraEditors.TextEdit edtMatKhau;
      private DevExpress.XtraEditors.TextEdit edtMail;
      private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private System.Windows.Forms.RadioButton rdbAdmin;
      private System.Windows.Forms.RadioButton rdbGiangVien;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
   }
}