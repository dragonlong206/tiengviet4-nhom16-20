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
            this.btnEnter = new CustomButton.ImageButton();
            this.lblBaiHoc = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.node4 = new DevComponents.AdvTree.Node();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.treDanhSachTuan = new System.Windows.Forms.TreeView();
            this.lblNhacNho = new DevComponents.DotNetBar.LabelX();
            this.bubbleBar1 = new DevComponents.DotNetBar.BubbleBar();
            this.bubbleBarTab2 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHome = new DevComponents.DotNetBar.BubbleButton();
            this.btnHuongDan = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
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
            // bubbleBar1
            // 
            this.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.bubbleBar1.AntiAlias = true;
            this.bubbleBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3;
            this.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3;
            this.bubbleBar1.ButtonBackgroundStretch = false;
            this.bubbleBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bubbleBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubbleBar1.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.bubbleBar1.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.bubbleBar1.Location = new System.Drawing.Point(205, 512);
            this.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.Name = "bubbleBar1";
            this.bubbleBar1.SelectedTab = this.bubbleBarTab2;
            this.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.bubbleBar1.Size = new System.Drawing.Size(384, 76);
            this.bubbleBar1.TabIndex = 31;
            this.bubbleBar1.Tabs.Add(this.bubbleBarTab2);
            this.bubbleBar1.TabsVisible = false;
            this.bubbleBar1.Text = "bubbleBar2";
            // 
            // bubbleBarTab2
            // 
            this.bubbleBarTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab2.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHome,
            this.btnHuongDan,
            this.btnThoat});
            this.bubbleBarTab2.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab2.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab2.Name = "bubbleBarTab2";
            this.bubbleBarTab2.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab2.Text = "btThanhDieuHuongDuoi";
            this.bubbleBarTab2.TextColor = System.Drawing.Color.Black;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageLarge")));
            this.btnHome.Name = "btnHome";
            this.btnHome.TooltipText = "Về trang đầu";
            this.btnHome.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnHome_Click_1);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.Image")));
            this.btnHuongDan.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnHuongDan.ImageLarge")));
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.TooltipText = "Thông tin trợ giúp";
            this.btnHuongDan.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnHuongDan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageLarge")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TooltipText = "Thoát";
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnThoat_Click_1);
            // 
            // ChonBaiHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.bubbleBar1);
            this.Controls.Add(this.lblNhacNho);
            this.Controls.Add(this.treDanhSachTuan);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBaiHoc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChonBaiHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chon bai hoc";
            this.Load += new System.EventHandler(this.frmChonBaiHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bubbleBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.ImageButton btnEnter;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblBaiHoc;
        private DevComponents.AdvTree.Node node4;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.TreeView treDanhSachTuan;
        private DevComponents.DotNetBar.LabelX lblNhacNho;
        private DevComponents.DotNetBar.BubbleBar bubbleBar1;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab2;
        private DevComponents.DotNetBar.BubbleButton btnHome;
        private DevComponents.DotNetBar.BubbleButton btnHuongDan;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
    }
}