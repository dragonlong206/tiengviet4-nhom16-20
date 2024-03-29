namespace TiengViet4
{
    partial class MainForm
    {
        public System.ComponentModel.ComponentResourceManager resources;
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
            this.resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTiengViet = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.pnlGioiThieu = new DevComponents.DotNetBar.ExpandablePanel();
            this.lblGiaiTri = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnEnter = new CustomButton.ImageButton();
            this.bubbleButton2 = new DevComponents.DotNetBar.BubbleButton();
            this.bubbleButton3 = new DevComponents.DotNetBar.BubbleButton();
            this.btnThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBar();
            this.btThanhDieuHuongDuoi = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.btnHuongDan = new DevComponents.DotNetBar.BubbleButton();
            this.btnThoat = new DevComponents.DotNetBar.BubbleButton();
            this.lblBatDau = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiengViet
            // 
            this.lblTiengViet.BackColor = System.Drawing.Color.Transparent;
            this.lblTiengViet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTiengViet.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiengViet.Location = new System.Drawing.Point(1, 90);
            this.lblTiengViet.Name = "lblTiengViet";
            this.lblTiengViet.Size = new System.Drawing.Size(178, 122);
            this.lblTiengViet.TabIndex = 4;
            this.lblTiengViet.Text = "<b><font size=\"+18\"><font color=\"#22B14C\"><font color=\"#ED1C24\">     Học tập</fon" +
                "t></font></font></b>";
            this.lblTiengViet.Click += new System.EventHandler(this.lblTiengViet_Click);
            // 
            // pnlGioiThieu
            // 
            this.pnlGioiThieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGioiThieu.CanvasColor = System.Drawing.Color.Transparent;
            this.pnlGioiThieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlGioiThieu.ExpandButtonVisible = false;
            this.pnlGioiThieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGioiThieu.Location = new System.Drawing.Point(185, 22);
            this.pnlGioiThieu.Name = "pnlGioiThieu";
            this.pnlGioiThieu.Size = new System.Drawing.Size(591, 317);
            this.pnlGioiThieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlGioiThieu.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.pnlGioiThieu.Style.BackColor2.Color = System.Drawing.Color.DeepSkyBlue;
            this.pnlGioiThieu.Style.Border = DevComponents.DotNetBar.eBorderType.Bump;
            this.pnlGioiThieu.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlGioiThieu.Style.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.pnlGioiThieu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlGioiThieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.pnlGioiThieu.Style.GradientAngle = 90;
            this.pnlGioiThieu.TabIndex = 3;
            this.pnlGioiThieu.Text = resources.GetString("pnlGioiThieu.Text");
            this.pnlGioiThieu.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlGioiThieu.TitleStyle.BackColor1.Color = System.Drawing.Color.DeepSkyBlue;
            this.pnlGioiThieu.TitleStyle.BackColor2.Color = System.Drawing.Color.Transparent;
            this.pnlGioiThieu.TitleStyle.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.BottomRight;
            this.pnlGioiThieu.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.Sunken;
            this.pnlGioiThieu.TitleStyle.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlGioiThieu.TitleStyle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.pnlGioiThieu.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlGioiThieu.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGioiThieu.TitleStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlGioiThieu.TitleStyle.GradientAngle = 90;
            this.pnlGioiThieu.TitleText = "Giới Thiệu";
            // 
            // lblGiaiTri
            // 
            this.lblGiaiTri.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaiTri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGiaiTri.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaiTri.Location = new System.Drawing.Point(1, 204);
            this.lblGiaiTri.Name = "lblGiaiTri";
            this.lblGiaiTri.Size = new System.Drawing.Size(178, 122);
            this.lblGiaiTri.TabIndex = 4;
            this.lblGiaiTri.Text = "<b><font size=\"+18\"><font color=\"#22B14C\"> <font color=\"#FF0ABE\">Giải trí</font><" +
                "/font></font></b>";
            this.lblGiaiTri.Click += new System.EventHandler(this.lblGiaiTri_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnter.BackgroundImage")));
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(648, 374);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(128, 128);
            this.btnEnter.TabIndex = 17;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.btnEnter.MouseEnter += new System.EventHandler(this.btnEnter_MouseEnter);
            this.btnEnter.MouseLeave += new System.EventHandler(this.btnEnter_MouseLeave);
            // 
            // bubbleButton2
            // 
            this.bubbleButton2.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.Image")));
            this.bubbleButton2.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton2.ImageLarge")));
            this.bubbleButton2.Name = "bubbleButton2";
            this.bubbleButton2.TooltipText = "Thông tin trợ giúp";
            // 
            // bubbleButton3
            // 
            this.bubbleButton3.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton3.Image")));
            this.bubbleButton3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton3.ImageLarge")));
            this.bubbleButton3.Name = "bubbleButton3";
            this.bubbleButton3.TooltipText = "Bật/Tắt nhạc";
            // 
            // btnThanhDieuHuongDuoi
            // 
            this.btnThanhDieuHuongDuoi.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom;
            this.btnThanhDieuHuongDuoi.AntiAlias = true;
            this.btnThanhDieuHuongDuoi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.btnThanhDieuHuongDuoi.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.BackgroundStyle.BackColor2 = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.BackgroundStyle.BackgroundImageAlpha = ((byte)(0));
            // 
            // 
            // 
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnThanhDieuHuongDuoi.ButtonBackAreaStyle.BackgroundImageAlpha = ((byte)(0));
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
            this.btnThanhDieuHuongDuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhDieuHuongDuoi.ImageSizeLarge = new System.Drawing.Size(86, 86);
            this.btnThanhDieuHuongDuoi.ImageSizeNormal = new System.Drawing.Size(64, 64);
            this.btnThanhDieuHuongDuoi.Location = new System.Drawing.Point(185, 502);
            this.btnThanhDieuHuongDuoi.MouseOverTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Name = "btnThanhDieuHuongDuoi";
            this.btnThanhDieuHuongDuoi.SelectedTab = this.btThanhDieuHuongDuoi;
            this.btnThanhDieuHuongDuoi.SelectedTabColors.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhDieuHuongDuoi.Size = new System.Drawing.Size(418, 97);
            this.btnThanhDieuHuongDuoi.TabIndex = 18;
            this.btnThanhDieuHuongDuoi.Tabs.Add(this.btThanhDieuHuongDuoi);
            this.btnThanhDieuHuongDuoi.TabsVisible = false;
            // 
            // btThanhDieuHuongDuoi
            // 
            this.btThanhDieuHuongDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.btThanhDieuHuongDuoi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.btThanhDieuHuongDuoi.Buttons.AddRange(new DevComponents.DotNetBar.BubbleButton[] {
            this.btnHuongDan,
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
            this.btnHuongDan.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnHuongDan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLarge = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageLarge")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.TooltipText = "Thoát";
            this.btnThoat.Click += new DevComponents.DotNetBar.ClickEventHandler(this.btnThoat_Click);
            // 
            // lblBatDau
            // 
            this.lblBatDau.BackColor = System.Drawing.Color.Transparent;
            this.lblBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatDau.Location = new System.Drawing.Point(685, 366);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(63, 23);
            this.lblBatDau.TabIndex = 19;
            this.lblBatDau.Text = "Bắt Đầu";
            this.lblBatDau.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblBatDau);
            this.Controls.Add(this.btnThanhDieuHuongDuoi);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblGiaiTri);
            this.Controls.Add(this.pnlGioiThieu);
            this.Controls.Add(this.lblTiengViet);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tieng Viet 4";
            ((System.ComponentModel.ISupportInitialize)(this.btnThanhDieuHuongDuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel lblTiengViet;
        private DevComponents.DotNetBar.ExpandablePanel pnlGioiThieu;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblGiaiTri;
        private CustomButton.ImageButton btnEnter;
        private DevComponents.DotNetBar.BubbleButton bubbleButton2;
        private DevComponents.DotNetBar.BubbleButton bubbleButton3;
        private DevComponents.DotNetBar.BubbleBar btnThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleBarTab btThanhDieuHuongDuoi;
        private DevComponents.DotNetBar.BubbleButton btnHuongDan;
        private DevComponents.DotNetBar.BubbleButton btnThoat;
        private DevComponents.DotNetBar.LabelX lblBatDau;
    }
}
