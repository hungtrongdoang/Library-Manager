﻿namespace Library_Manager
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem4 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem5 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem6 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tienIchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptbImg = new System.Windows.Forms.PictureBox();
            this.oFDImage = new System.Windows.Forms.OpenFileDialog();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeSystem = new System.Windows.Forms.Timer(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblMode = new System.Windows.Forms.ToolStripLabel();
            this.lblAccount = new System.Windows.Forms.ToolStripLabel();
            this.lblTimeSys = new System.Windows.Forms.ToolStripLabel();
            this.btnMode = new System.Windows.Forms.Button();
            this.tsbtnFindMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnDelMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnUpdateMode = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rbtnFindbyId = new System.Windows.Forms.RadioButton();
            this.rbtnFindbyName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barLargeButtonItem1,
            this.barLargeButtonItem2,
            this.barLargeButtonItem3,
            this.barLargeButtonItem4,
            this.barLargeButtonItem5,
            this.barLargeButtonItem6,
            this.barStaticItem1});
            this.barManager1.MaxItemId = 12;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(558, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(558, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(558, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Tìm sinh viên";
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm sinh viên";
            this.barLargeButtonItem2.Id = 1;
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Xóa sinh viên";
            this.barLargeButtonItem3.Id = 2;
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // barLargeButtonItem4
            // 
            this.barLargeButtonItem4.Caption = "Cập nhật sinh viên";
            this.barLargeButtonItem4.Id = 3;
            this.barLargeButtonItem4.Name = "barLargeButtonItem4";
            // 
            // barLargeButtonItem5
            // 
            this.barLargeButtonItem5.Caption = "Cập nhật dữ liệu";
            this.barLargeButtonItem5.Id = 4;
            this.barLargeButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barLargeButtonItem5.ImageOptions.LargeImage")));
            this.barLargeButtonItem5.Name = "barLargeButtonItem5";
            this.barLargeButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barLargeButtonItem6
            // 
            this.barLargeButtonItem6.Caption = "Đóng của sổ";
            this.barLargeButtonItem6.Id = 5;
            this.barLargeButtonItem6.Name = "barLargeButtonItem6";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.cheDoToolStripMenuItem,
            this.tienIchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(558, 29);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.heThongToolStripMenuItem.Text = "Hệ thống";
            this.heThongToolStripMenuItem.Click += new System.EventHandler(this.heThongToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // cheDoToolStripMenuItem
            // 
            this.cheDoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timToolStripMenuItem,
            this.themToolStripMenuItem,
            this.xoaToolStripMenuItem,
            this.suaToolStripMenuItem});
            this.cheDoToolStripMenuItem.Name = "cheDoToolStripMenuItem";
            this.cheDoToolStripMenuItem.Size = new System.Drawing.Size(79, 27);
            this.cheDoToolStripMenuItem.Text = "Chế độ";
            // 
            // timToolStripMenuItem
            // 
            this.timToolStripMenuItem.Name = "timToolStripMenuItem";
            this.timToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.timToolStripMenuItem.Text = "Tìm...";
            this.timToolStripMenuItem.Click += new System.EventHandler(this.timToolStripMenuItem_Click);
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.themToolStripMenuItem.Text = "Thêm...";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(149, 28);
            this.suaToolStripMenuItem.Text = "Sửa";
            this.suaToolStripMenuItem.Click += new System.EventHandler(this.suaToolStripMenuItem_Click);
            // 
            // tienIchToolStripMenuItem
            // 
            this.tienIchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinToolStripMenuItem});
            this.tienIchToolStripMenuItem.Name = "tienIchToolStripMenuItem";
            this.tienIchToolStripMenuItem.Size = new System.Drawing.Size(83, 27);
            this.tienIchToolStripMenuItem.Text = "Tiện ích";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.thongTinToolStripMenuItem.Text = "Thông tin";
            this.thongTinToolStripMenuItem.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // ptbImg
            // 
            this.ptbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbImg.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbImg.ErrorImage")));
            this.ptbImg.Image = ((System.Drawing.Image)(resources.GetObject("ptbImg.Image")));
            this.ptbImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbImg.InitialImage")));
            this.ptbImg.Location = new System.Drawing.Point(12, 312);
            this.ptbImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbImg.Name = "ptbImg";
            this.ptbImg.Size = new System.Drawing.Size(103, 77);
            this.ptbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImg.TabIndex = 10;
            this.ptbImg.TabStop = false;
            this.ptbImg.Click += new System.EventHandler(this.ptbImg_Click);
            // 
            // oFDImage
            // 
            this.oFDImage.FileName = "openFileDialog1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(135, 322);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(107, 25);
            this.btnAddImage.TabIndex = 7;
            this.btnAddImage.Text = "Thêm hình";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điện thoại";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timeSystem
            // 
            this.timeSystem.Enabled = true;
            this.timeSystem.Interval = 1000;
            this.timeSystem.Tick += new System.EventHandler(this.timeSystem_Tick);
            // 
            // txtId
            // 
            this.txtId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtId.Location = new System.Drawing.Point(135, 135);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.MaxLength = 15;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(240, 22);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(135, 185);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(135, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.VerifyInput_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(135, 275);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 22);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextChanged += new System.EventHandler(this.VerifyInputPhone_TextChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Silver;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMode,
            this.lblAccount,
            this.lblTimeSys});
            this.toolStrip2.Location = new System.Drawing.Point(0, 458);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip2.Size = new System.Drawing.Size(558, 25);
            this.toolStrip2.TabIndex = 36;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblMode
            // 
            this.lblMode.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblMode.ForeColor = System.Drawing.Color.Green;
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(54, 22);
            this.lblMode.Text = "Mode";
            // 
            // lblAccount
            // 
            this.lblAccount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAccount.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAccount.ForeColor = System.Drawing.Color.Maroon;
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(74, 22);
            this.lblAccount.Text = "Account";
            // 
            // lblTimeSys
            // 
            this.lblTimeSys.Font = new System.Drawing.Font("Times New Roman", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblTimeSys.Name = "lblTimeSys";
            this.lblTimeSys.Size = new System.Drawing.Size(83, 22);
            this.lblTimeSys.Text = "Thời gian";
            this.lblTimeSys.Click += new System.EventHandler(this.lblTimeSys_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(197, 379);
            this.btnMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(93, 35);
            this.btnMode.TabIndex = 8;
            this.btnMode.Text = "mode";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // tsbtnFindMode
            // 
            this.tsbtnFindMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFindMode.Image")));
            this.tsbtnFindMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFindMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFindMode.Name = "tsbtnFindMode";
            this.tsbtnFindMode.Size = new System.Drawing.Size(42, 84);
            this.tsbtnFindMode.Text = "Tìm";
            this.tsbtnFindMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnFindMode.Click += new System.EventHandler(this.tsbtnFindMode_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 87);
            // 
            // tsbtnAddMode
            // 
            this.tsbtnAddMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddMode.Image")));
            this.tsbtnAddMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAddMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddMode.Name = "tsbtnAddMode";
            this.tsbtnAddMode.Size = new System.Drawing.Size(57, 84);
            this.tsbtnAddMode.Text = "Thêm";
            this.tsbtnAddMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnAddMode.Click += new System.EventHandler(this.tsbtnAddMode_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 87);
            // 
            // tsbtnDelMode
            // 
            this.tsbtnDelMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDelMode.Image")));
            this.tsbtnDelMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnDelMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelMode.Name = "tsbtnDelMode";
            this.tsbtnDelMode.Size = new System.Drawing.Size(43, 84);
            this.tsbtnDelMode.Text = "Xóa";
            this.tsbtnDelMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDelMode.Click += new System.EventHandler(this.tsbtnDelMode_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 87);
            // 
            // tsbtnUpdateMode
            // 
            this.tsbtnUpdateMode.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateMode.Image")));
            this.tsbtnUpdateMode.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUpdateMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateMode.Name = "tsbtnUpdateMode";
            this.tsbtnUpdateMode.Size = new System.Drawing.Size(42, 84);
            this.tsbtnUpdateMode.Text = "Sửa";
            this.tsbtnUpdateMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdateMode.Click += new System.EventHandler(this.tsbtnUpdateMode_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 87);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(58, 84);
            this.tsbtnExit.Text = "Thoát";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 87);
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 84);
            this.btnReset.Text = "Đặt lại";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReset.ToolTipText = "Đặt lại";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Khaki;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnFindMode,
            this.toolStripSeparator1,
            this.tsbtnAddMode,
            this.toolStripSeparator2,
            this.tsbtnDelMode,
            this.toolStripSeparator3,
            this.tsbtnUpdateMode,
            this.toolStripSeparator4,
            this.tsbtnExit,
            this.toolStripSeparator5,
            this.btnReset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 87);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rbtnFindbyId
            // 
            this.rbtnFindbyId.AutoSize = true;
            this.rbtnFindbyId.Location = new System.Drawing.Point(135, 160);
            this.rbtnFindbyId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFindbyId.Name = "rbtnFindbyId";
            this.rbtnFindbyId.Size = new System.Drawing.Size(171, 21);
            this.rbtnFindbyId.TabIndex = 42;
            this.rbtnFindbyId.TabStop = true;
            this.rbtnFindbyId.Text = "Tìm bằng mã sinh viên";
            this.rbtnFindbyId.UseVisualStyleBackColor = true;
            this.rbtnFindbyId.Visible = false;
            this.rbtnFindbyId.CheckedChanged += new System.EventHandler(this.rbtnFindbyId_CheckedChanged);
            // 
            // rbtnFindbyName
            // 
            this.rbtnFindbyName.AutoSize = true;
            this.rbtnFindbyName.Location = new System.Drawing.Point(135, 211);
            this.rbtnFindbyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFindbyName.Name = "rbtnFindbyName";
            this.rbtnFindbyName.Size = new System.Drawing.Size(172, 21);
            this.rbtnFindbyName.TabIndex = 43;
            this.rbtnFindbyName.TabStop = true;
            this.rbtnFindbyName.Text = "Tìm bằng tên sinh viên";
            this.rbtnFindbyName.UseVisualStyleBackColor = true;
            this.rbtnFindbyName.Visible = false;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 483);
            this.Controls.Add(this.rbtnFindbyName);
            this.Controls.Add(this.rbtnFindbyId);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.ptbImg);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("StudentForm.IconOptions.Icon")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("StudentForm.IconOptions.LargeImage")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.Text = "Thao tác với tài khoản sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImg)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem4;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem5;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem6;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox ptbImg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog oFDImage;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timeSystem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblMode;
        private System.Windows.Forms.ToolStripLabel lblAccount;
        private System.Windows.Forms.ToolStripLabel lblTimeSys;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tienIchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnFindMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAddMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateMode;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.RadioButton rbtnFindbyName;
        private System.Windows.Forms.RadioButton rbtnFindbyId;
    }
}