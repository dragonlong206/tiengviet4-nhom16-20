namespace TiengViet4
{
    partial class ChonBaiHocForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonBaiHocForm));
            this.btnThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHuongDan = new DevComponents.DotNetBar.BubbleButton();
            this.btnAmThanh = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            this.btnEnter = new CustomButton.ImageButton();
            this.lblBaiHoc = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.node4 = new DevComponents.AdvTree.Node();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.treDanhSachTuan = new System.Windows.Forms.TreeView();
            this.lblNhacNho = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThanhDieuHuongDuoi
            // 
            this.btnThanhDieuHuongDuoi.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.btnThanhDieuHuongDuoi.AntiAlias = true;
            this.btnThanhDieuHuongDuoi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingBottom = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingLeft = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingRight = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.PaddingTop = 3;
            this.btnThanhDieuHuongDuoi.ButtonBackgroundStretch = false;
            this.btnThanhDieuHuongDuoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThanhDieuHuongDuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuongDuoi.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuongDuoi.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuongDuoi.Location = new System.Drawing.Point(250, 492);
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Name = "btnThanhDieuHuongDuoi";
            this.btnThanhDieuHuongDuoi.SelectedTab = this.btThanhDieuHuongDuoi;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BackColor2 = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Size = new System.Drawing.Size(294, 76);
            this.btnThanhDieuHuongDuoi.TabIndex = 0;
            this.btnThanhDieuHuongDuoi.Tabs.Add(this.btThanhDieuHuongDuoi);
            this.btnThanhDieuHuongDuoi.TabsVisible = false;
            // 
            // btThanhDieuHuongDuoi
            // 
            this.btThanhDieuHuongDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuongDuoi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuongDuoi.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHuongDan,
            this.btnAmThanh,
            this.btnThoat});
            this.btThanhDieuHuongDuoi.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btThanhDieuHuongDuoi.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThanhDieuHuongDuoi.Name = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.btThanhDieuHuongDuoi.Text = "btThanhDieuHuongDuoi";
            this.btThanhDieuHuongDuoi.TextColor = System.Drawing.Color.Black;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.ImageLarge")));
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.TooltipText = "Thông tin trợ giúp";
            // 
            // btnAmThanh
            // 
            this.btnAmThanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmThanh.Image = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.Image")));
            this.btnAmThanh.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnAmThanh.ImageLarge")));
            this.btnAmThanh.Name = "btnAmThanh";
            this.btnAmThanh.TooltipText = "Bật/Tắt nhạc";
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageLarge")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TooltipText = "Thoát";
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.BtnThoat_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
           // this.btnEnter.BackgroundImage1 = null;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(349, 389);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(98, 97);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblBaiHoc
            // 
            this.lblBaiHoc.BackColor = System.Drawing.Color.Transparent;
            this.lblBaiHoc.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiHoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBaiHoc.Location = new System.Drawing.Point(263, -2);
            this.lblBaiHoc.Name = "lblBaiHoc";
            this.lblBaiHoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBaiHoc.Size = new System.Drawing.Size(272, 85);
            this.lblBaiHoc.TabIndex = 3;
            this.lblBaiHoc.Text = "<font color=\"#00C505\"><b><i><font color=\"#903C39\">BÀI HỌC</font></i></b></font>";
            // 
            // node4
            // 
            this.node4.Name = "node4";
            this.node4.Text = "Bài 3:.....";
            // 
            // elementStyle1
            // 
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // treDanhSachTuan
            // 
            this.treDanhSachTuan.BackColor = System.Drawing.Color.Turquoise;
            this.treDanhSachTuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treDanhSachTuan.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treDanhSachTuan.ForeColor = System.Drawing.Color.DarkBlue;
            this.treDanhSachTuan.LineColor = System.Drawing.Color.Blue;
            this.treDanhSachTuan.Location = new System.Drawing.Point(159, 80);
            this.treDanhSachTuan.Name = "treDanhSachTuan";
            this.treDanhSachTuan.Size = new System.Drawing.Size(482, 303);
            this.treDanhSachTuan.TabIndex = 7;
            this.treDanhSachTuan.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treDanhSachTuan_NodeMouseDoubleClick);
            this.treDanhSachTuan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treDanhSachTuan_MouseMove);
            // 
            // lblNhacNho
            // 
            this.lblNhacNho.BackColor = System.Drawing.Color.Turquoise;
            this.lblNhacNho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhacNho.Location = new System.Drawing.Point(413, 115);
            this.lblNhacNho.Name = "lblNhacNho";
            this.lblNhacNho.Size = new System.Drawing.Size(194, 80);
            this.lblNhacNho.TabIndex = 8;
            this.lblNhacNho.Text = "Em phải chọn một\r\nbài học trước đã";
            this.lblNhacNho.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblNhacNho.Visible = false;
            // 
            // ChonBaiHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblNhacNho);
            this.Controls.Add(this.treDanhSachTuan);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBaiHoc);
            this.Controls.Add(this.btnThanhDieuHuongDuoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChonBaiHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chon bai hoc";
            this.Load += new System.EventHandler(this.frmChonBaiHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleButton btnHuongDan;
        private DevComponents.DotNetBar.BubbleButton btnAmThanh;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
        private CustomButton.ImageButton btnEnter;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblBaiHoc;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.TreeView treDanhSachTuan;
        private DevComponents.DotNetBar.LabelX lblNhacNho;
    }
}