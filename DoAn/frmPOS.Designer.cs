﻿namespace DoAn
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.btnThanhToan = new DevComponents.DotNetBar.ButtonX();
            this.lbTienThua = new DevComponents.DotNetBar.LabelX();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lbCanTra = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.lbGiamGia = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.lbTongTien = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lbKH = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lbThoiGian = new DevComponents.DotNetBar.LabelX();
            this.lbNhanVien = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoMoiHD = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLoaiThe = new DevComponents.DotNetBar.LabelX();
            this.txtMaKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvDonHang = new System.Windows.Forms.DataGridView();
            this.txtThanhToan = new ThietKeControl.NumbericTextbox();
            this.txtSL = new ThietKeControl.NumbericTextbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThanhToan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThanhToan.Location = new System.Drawing.Point(102, 534);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(120, 40);
            this.btnThanhToan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lbTienThua
            // 
            // 
            // 
            // 
            this.lbTienThua.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTienThua.FontBold = true;
            this.lbTienThua.ForeColor = System.Drawing.Color.Maroon;
            this.lbTienThua.Location = new System.Drawing.Point(183, 490);
            this.lbTienThua.Name = "lbTienThua";
            this.lbTienThua.Size = new System.Drawing.Size(117, 23);
            this.lbTienThua.TabIndex = 18;
            this.lbTienThua.Text = "0 VNĐ";
            this.lbTienThua.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(44, 463);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(168, 23);
            this.line2.TabIndex = 17;
            this.line2.Text = "line2";
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(44, 274);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(168, 23);
            this.line1.TabIndex = 16;
            this.line1.Text = "line1";
            // 
            // labelX12
            // 
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.FontBold = true;
            this.labelX12.Location = new System.Drawing.Point(11, 492);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(138, 19);
            this.labelX12.TabIndex = 15;
            this.labelX12.Text = "Tiền thừa trả khách:";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(11, 417);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(125, 23);
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "Khách thanh toán";
            // 
            // lbCanTra
            // 
            // 
            // 
            // 
            this.lbCanTra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbCanTra.FontBold = true;
            this.lbCanTra.ForeColor = System.Drawing.Color.Maroon;
            this.lbCanTra.Location = new System.Drawing.Point(183, 380);
            this.lbCanTra.Name = "lbCanTra";
            this.lbCanTra.Size = new System.Drawing.Size(117, 23);
            this.lbCanTra.TabIndex = 12;
            this.lbCanTra.Text = "0";
            this.lbCanTra.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.FontBold = true;
            this.labelX11.Location = new System.Drawing.Point(11, 382);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(109, 19);
            this.labelX11.TabIndex = 11;
            this.labelX11.Text = "Khách cần trả:";
            // 
            // lbGiamGia
            // 
            // 
            // 
            // 
            this.lbGiamGia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbGiamGia.FontBold = true;
            this.lbGiamGia.ForeColor = System.Drawing.Color.Maroon;
            this.lbGiamGia.Location = new System.Drawing.Point(183, 343);
            this.lbGiamGia.Name = "lbGiamGia";
            this.lbGiamGia.Size = new System.Drawing.Size(117, 23);
            this.lbGiamGia.TabIndex = 10;
            this.lbGiamGia.Text = "0";
            this.lbGiamGia.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lbGiamGia.TextChanged += new System.EventHandler(this.lbGiamGia_TextChanged);
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.FontBold = true;
            this.labelX10.Location = new System.Drawing.Point(11, 345);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(69, 19);
            this.labelX10.TabIndex = 9;
            this.labelX10.Text = "Giảm giá:";
            // 
            // lbTongTien
            // 
            // 
            // 
            // 
            this.lbTongTien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTongTien.FontBold = true;
            this.lbTongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lbTongTien.Location = new System.Drawing.Point(183, 303);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(117, 23);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "0";
            this.lbTongTien.TextAlignment = System.Drawing.StringAlignment.Far;
            this.lbTongTien.TextChanged += new System.EventHandler(this.lbTongTien_TextChanged);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.FontBold = true;
            this.labelX8.Location = new System.Drawing.Point(11, 303);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(110, 23);
            this.labelX8.TabIndex = 7;
            this.labelX8.Text = "Tổng tiền hàng:";
            // 
            // lbKH
            // 
            // 
            // 
            // 
            this.lbKH.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbKH.Location = new System.Drawing.Point(132, 202);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(170, 23);
            this.lbKH.TabIndex = 6;
            this.lbKH.Text = "Nguyễn Thị Nhật";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.FontBold = true;
            this.labelX7.Location = new System.Drawing.Point(13, 202);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(109, 23);
            this.labelX7.TabIndex = 5;
            this.labelX7.Text = "Khách hàng:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(13, 163);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(109, 23);
            this.labelX6.TabIndex = 3;
            this.labelX6.Text = "Mã khách hàng:";
            // 
            // lbThoiGian
            // 
            // 
            // 
            // 
            this.lbThoiGian.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbThoiGian.Location = new System.Drawing.Point(13, 121);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(233, 23);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "Thời gian: ";
            // 
            // lbNhanVien
            // 
            // 
            // 
            // 
            this.lbNhanVien.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbNhanVien.Location = new System.Drawing.Point(13, 82);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(306, 23);
            this.lbNhanVien.TabIndex = 1;
            this.lbNhanVien.Text = "Nhân viên bán hàng: Phương Uyên";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(24, 24);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(223, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(695, 15);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.buttonX1.Size = new System.Drawing.Size(50, 50);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 8;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(247, 13);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(431, 24);
            this.txtMaSP.TabIndex = 6;
            this.txtMaSP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaSP_KeyDown);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(144, 49);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Số lượng";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(144, 10);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 32);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Mã sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTaoMoiHD);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.buttonX1);
            this.panel1.Controls.Add(this.txtMaSP);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 111);
            this.panel1.TabIndex = 0;
            // 
            // btnTaoMoiHD
            // 
            this.btnTaoMoiHD.Location = new System.Drawing.Point(18, 15);
            this.btnTaoMoiHD.Name = "btnTaoMoiHD";
            this.btnTaoMoiHD.Size = new System.Drawing.Size(80, 60);
            this.btnTaoMoiHD.TabIndex = 10;
            this.btnTaoMoiHD.Text = "Tạo mới đơn hàng";
            this.btnTaoMoiHD.UseVisualStyleBackColor = true;
            this.btnTaoMoiHD.Click += new System.EventHandler(this.btnTaoMoiHD_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhToan);
            this.panel2.Controls.Add(this.lbLoaiThe);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.lbTienThua);
            this.panel2.Controls.Add(this.line2);
            this.panel2.Controls.Add(this.line1);
            this.panel2.Controls.Add(this.labelX12);
            this.panel2.Controls.Add(this.labelX9);
            this.panel2.Controls.Add(this.lbCanTra);
            this.panel2.Controls.Add(this.labelX11);
            this.panel2.Controls.Add(this.lbGiamGia);
            this.panel2.Controls.Add(this.labelX10);
            this.panel2.Controls.Add(this.lbTongTien);
            this.panel2.Controls.Add(this.labelX8);
            this.panel2.Controls.Add(this.lbKH);
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.labelX6);
            this.panel2.Controls.Add(this.lbThoiGian);
            this.panel2.Controls.Add(this.lbNhanVien);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(768, 3);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(322, 580);
            this.panel2.TabIndex = 2;
            // 
            // lbLoaiThe
            // 
            // 
            // 
            // 
            this.lbLoaiThe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbLoaiThe.ForeColor = System.Drawing.Color.Maroon;
            this.lbLoaiThe.Location = new System.Drawing.Point(132, 231);
            this.lbLoaiThe.Name = "lbLoaiThe";
            this.lbLoaiThe.Size = new System.Drawing.Size(170, 23);
            this.lbLoaiThe.TabIndex = 21;
            this.lbLoaiThe.Text = "Đồng";
            // 
            // txtMaKH
            // 
            // 
            // 
            // 
            this.txtMaKH.Border.Class = "TextBoxBorder";
            this.txtMaKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaKH.ButtonCustom.Checked = true;
            this.txtMaKH.ButtonCustom.Symbol = "";
            this.txtMaKH.ButtonCustom.Visible = true;
            this.txtMaKH.Location = new System.Drawing.Point(132, 162);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PreventEnterBeep = true;
            this.txtMaKH.Size = new System.Drawing.Size(170, 24);
            this.txtMaKH.TabIndex = 20;
            this.txtMaKH.ButtonCustomClick += new System.EventHandler(this.txtMaKH_ButtonCustomClick);
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtgvDonHang, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 586);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtgvDonHang
            // 
            this.dtgvDonHang.AllowUserToAddRows = false;
            this.dtgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDonHang.Location = new System.Drawing.Point(3, 120);
            this.dtgvDonHang.Name = "dtgvDonHang";
            this.dtgvDonHang.ReadOnly = true;
            this.dtgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDonHang.Size = new System.Drawing.Size(759, 463);
            this.dtgvDonHang.TabIndex = 3;
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.Location = new System.Drawing.Point(132, 416);
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Size = new System.Drawing.Size(170, 24);
            this.txtThanhToan.TabIndex = 22;
            this.txtThanhToan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtThanhToan_KeyDown);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(247, 48);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(431, 24);
            this.txtSL.TabIndex = 9;
            this.txtSL.Text = "1";
            this.txtSL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSL_KeyDown);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnThanhToan;
        private DevComponents.DotNetBar.LabelX lbTienThua;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lbCanTra;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX lbGiamGia;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX lbTongTien;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX lbKH;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lbThoiGian;
        private DevComponents.DotNetBar.LabelX lbNhanVien;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.TextBox txtMaSP;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ThietKeControl.NumbericTextbox txtSL;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaKH;
        private DevComponents.DotNetBar.LabelX lbLoaiThe;
        private ThietKeControl.NumbericTextbox txtThanhToan;
        private System.Windows.Forms.Button btnTaoMoiHD;
        private System.Windows.Forms.DataGridView dtgvDonHang;
    }
}