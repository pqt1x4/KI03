namespace MAINPROJECT
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "","49.01.103.039","Mai Yến Khoa","100%","Viết báo cáo, Powerpoint" },-1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "","49.01.103.056","Phùng Ngọc Nhân","100%","Viết báo cáo, Code" },-1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "","49.01.103.079","Phan Thị Quý Thịnh","100%","Viết báo cáo, Code" },-1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "","49.01.103.087","Lương Lý Ngọc Trầm","100%","Viết báo cáo, Powerpoint" },-1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel_Left=new Panel();
            bt_Manage=new Button();
            bt_Show=new Button();
            pictureBox1=new PictureBox();
            panel_Top=new Panel();
            lb_Title=new Label();
            panel_Body=new Panel();
            listView1=new ListView();
            columnHeader4=new ColumnHeader();
            columnHeader1=new ColumnHeader();
            columnHeader2=new ColumnHeader();
            columnHeader5=new ColumnHeader();
            columnHeader3=new ColumnHeader();
            textBox6=new TextBox();
            textBox5=new TextBox();
            pictureBox2=new PictureBox();
            textBox4=new TextBox();
            textBox3=new TextBox();
            textBox2=new TextBox();
            textBox1=new TextBox();
            tb_title2=new TextBox();
            tb_title=new TextBox();
            imageList1=new ImageList(components);
            panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_Top.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_Left
            // 
            panel_Left.BackColor=Color.Cornsilk;
            panel_Left.BorderStyle=BorderStyle.Fixed3D;
            panel_Left.Controls.Add(bt_Manage);
            panel_Left.Controls.Add(bt_Show);
            panel_Left.Controls.Add(pictureBox1);
            panel_Left.Dock=DockStyle.Left;
            panel_Left.Location=new Point(0,0);
            panel_Left.Margin=new Padding(3,4,3,4);
            panel_Left.Name="panel_Left";
            panel_Left.Size=new Size(137,1055);
            panel_Left.TabIndex=0;
            // 
            // bt_Manage
            // 
            bt_Manage.BackColor=Color.FromArgb(255,128,128);
            bt_Manage.Dock=DockStyle.Top;
            bt_Manage.FlatAppearance.BorderSize=0;
            bt_Manage.FlatStyle=FlatStyle.Flat;
            bt_Manage.Font=new Font("Segoe UI Black",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_Manage.Location=new Point(0,230);
            bt_Manage.Margin=new Padding(3,4,3,4);
            bt_Manage.Name="bt_Manage";
            bt_Manage.Size=new Size(133,100);
            bt_Manage.TabIndex=2;
            bt_Manage.Text="QUẢN LÍ";
            bt_Manage.UseVisualStyleBackColor=false;
            bt_Manage.Click+=bt_Manage_Click;
            // 
            // bt_Show
            // 
            bt_Show.BackColor=Color.FromArgb(128,128,255);
            bt_Show.Dock=DockStyle.Top;
            bt_Show.FlatAppearance.BorderSize=0;
            bt_Show.FlatStyle=FlatStyle.Flat;
            bt_Show.Font=new Font("Segoe UI Black",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_Show.Location=new Point(0,130);
            bt_Show.Margin=new Padding(3,4,3,4);
            bt_Show.Name="bt_Show";
            bt_Show.Size=new Size(133,100);
            bt_Show.TabIndex=1;
            bt_Show.Text="HIỂN THỊ";
            bt_Show.UseVisualStyleBackColor=false;
            bt_Show.Click+=bt_Show_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock=DockStyle.Top;
            pictureBox1.Image=Properties.Resources.logoKN2T_removebg1;
            pictureBox1.Location=new Point(0,0);
            pictureBox1.Margin=new Padding(3,4,3,4);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(133,130);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            pictureBox1.Click+=pictureBox1_Click;
            // 
            // panel_Top
            // 
            panel_Top.BackColor=Color.PaleGoldenrod;
            panel_Top.Controls.Add(lb_Title);
            panel_Top.Dock=DockStyle.Top;
            panel_Top.Location=new Point(137,0);
            panel_Top.Margin=new Padding(3,4,3,4);
            panel_Top.Name="panel_Top";
            panel_Top.Size=new Size(1787,53);
            panel_Top.TabIndex=1;
            // 
            // lb_Title
            // 
            lb_Title.AutoSize=true;
            lb_Title.Font=new Font("Segoe UI Black",14.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_Title.Location=new Point(7,11);
            lb_Title.Name="lb_Title";
            lb_Title.Size=new Size(1084,32);
            lb_Title.TabIndex=0;
            lb_Title.Text="GIỚI THIỆU HỆ THỐNG TRA CỨU ĐƯỜNG BAY NGẮN NHẤT BẰNG THUẬT TOÁN DIJKSTRA";
            lb_Title.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // panel_Body
            // 
            panel_Body.AutoSize=true;
            panel_Body.BackColor=SystemColors.ControlLight;
            panel_Body.Controls.Add(listView1);
            panel_Body.Controls.Add(textBox6);
            panel_Body.Controls.Add(textBox5);
            panel_Body.Controls.Add(pictureBox2);
            panel_Body.Controls.Add(textBox4);
            panel_Body.Controls.Add(textBox3);
            panel_Body.Controls.Add(textBox2);
            panel_Body.Controls.Add(textBox1);
            panel_Body.Controls.Add(tb_title2);
            panel_Body.Controls.Add(tb_title);
            panel_Body.Dock=DockStyle.Fill;
            panel_Body.Location=new Point(137,53);
            panel_Body.Margin=new Padding(3,4,3,4);
            panel_Body.Name="panel_Body";
            panel_Body.Size=new Size(1787,1002);
            panel_Body.TabIndex=2;
            // 
            // listView1
            // 
            listView1.BackColor=SystemColors.GradientInactiveCaption;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader4,columnHeader1,columnHeader2,columnHeader5,columnHeader3 });
            listView1.Font=new Font("Segoe UI",13.8F,FontStyle.Regular,GraphicsUnit.Point,0);
            listView1.ForeColor=SystemColors.InactiveCaptionText;
            listView1.GridLines=true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1,listViewItem2,listViewItem3,listViewItem4 });
            listView1.Location=new Point(128,609);
            listView1.Margin=new Padding(3,4,3,4);
            listView1.Name="listView1";
            listView1.Size=new Size(820,191);
            listView1.TabIndex=12;
            listView1.UseCompatibleStateImageBehavior=false;
            listView1.View=View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.DisplayIndex=3;
            columnHeader4.Width=0;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex=0;
            columnHeader1.Text="MSSV";
            columnHeader1.Width=150;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex=1;
            columnHeader2.Text="HỌ VÀ TÊN";
            columnHeader2.TextAlign=HorizontalAlignment.Center;
            columnHeader2.Width=250;
            // 
            // columnHeader5
            // 
            columnHeader5.DisplayIndex=4;
            columnHeader5.Text="MỨC ĐỘ";
            columnHeader5.TextAlign=HorizontalAlignment.Center;
            columnHeader5.Width=120;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex=2;
            columnHeader3.Text="PHÂN CÔNG";
            columnHeader3.TextAlign=HorizontalAlignment.Center;
            columnHeader3.Width=280;
            // 
            // textBox6
            // 
            textBox6.BackColor=SystemColors.ControlLight;
            textBox6.BorderStyle=BorderStyle.None;
            textBox6.Font=new Font("Segoe UI Black",16.2F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox6.ForeColor=Color.Black;
            textBox6.Location=new Point(400,482);
            textBox6.Margin=new Padding(9,11,9,11);
            textBox6.Multiline=true;
            textBox6.Name="textBox6";
            textBox6.ReadOnly=true;
            textBox6.ShortcutsEnabled=false;
            textBox6.Size=new Size(224,43);
            textBox6.TabIndex=11;
            textBox6.TabStop=false;
            textBox6.Text="2411COMP170101";
            textBox6.TextAlign=HorizontalAlignment.Center;
            textBox6.WordWrap=false;
            // 
            // textBox5
            // 
            textBox5.BackColor=SystemColors.ControlLight;
            textBox5.BorderStyle=BorderStyle.None;
            textBox5.Font=new Font("Segoe UI Black",16.2F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox5.ForeColor=Color.Green;
            textBox5.Location=new Point(45,482);
            textBox5.Margin=new Padding(9,11,9,11);
            textBox5.Name="textBox5";
            textBox5.ReadOnly=true;
            textBox5.ShortcutsEnabled=false;
            textBox5.Size=new Size(304,37);
            textBox5.TabIndex=10;
            textBox5.TabStop=false;
            textBox5.Text="MÃ LỚP HỌC PHẦN:";
            textBox5.WordWrap=false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor=Color.Transparent;
            pictureBox2.BackgroundImageLayout=ImageLayout.Stretch;
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(851,650);
            pictureBox2.Margin=new Padding(3,4,3,4);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(698,300);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=9;
            pictureBox2.TabStop=false;
            // 
            // textBox4
            // 
            textBox4.BackColor=SystemColors.ControlLight;
            textBox4.BorderStyle=BorderStyle.None;
            textBox4.Font=new Font("Segoe UI",15.75F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox4.ForeColor=Color.Black;
            textBox4.Location=new Point(424,889);
            textBox4.Margin=new Padding(9,11,9,11);
            textBox4.Multiline=true;
            textBox4.Name="textBox4";
            textBox4.ReadOnly=true;
            textBox4.ShortcutsEnabled=false;
            textBox4.Size=new Size(281,43);
            textBox4.TabIndex=8;
            textBox4.TabStop=false;
            textBox4.Text="ThS. Trần Quang Huy";
            textBox4.WordWrap=false;
            // 
            // textBox3
            // 
            textBox3.BackColor=SystemColors.ControlLight;
            textBox3.BorderStyle=BorderStyle.None;
            textBox3.Font=new Font("Segoe UI",15.75F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox3.ForeColor=Color.Black;
            textBox3.Location=new Point(424,835);
            textBox3.Margin=new Padding(9,11,9,11);
            textBox3.Multiline=true;
            textBox3.Name="textBox3";
            textBox3.ReadOnly=true;
            textBox3.ShortcutsEnabled=false;
            textBox3.Size=new Size(295,43);
            textBox3.TabIndex=7;
            textBox3.TabStop=false;
            textBox3.Text="TS. Nguyễn Viết Hưng";
            textBox3.WordWrap=false;
            // 
            // textBox2
            // 
            textBox2.BackColor=SystemColors.ControlLight;
            textBox2.BorderStyle=BorderStyle.None;
            textBox2.Font=new Font("Segoe UI Black",16.2F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox2.ForeColor=Color.Green;
            textBox2.Location=new Point(45,835);
            textBox2.Margin=new Padding(9,11,9,11);
            textBox2.Name="textBox2";
            textBox2.ReadOnly=true;
            textBox2.ShortcutsEnabled=false;
            textBox2.Size=new Size(411,37);
            textBox2.TabIndex=6;
            textBox2.TabStop=false;
            textBox2.Text="GIẢNG VIÊN HƯỚNG DẪN:";
            // 
            // textBox1
            // 
            textBox1.BackColor=SystemColors.ControlLight;
            textBox1.BorderStyle=BorderStyle.None;
            textBox1.Font=new Font("Segoe UI Black",16.2F,FontStyle.Bold,GraphicsUnit.Point,0);
            textBox1.ForeColor=Color.Green;
            textBox1.Location=new Point(45,552);
            textBox1.Margin=new Padding(9,11,9,11);
            textBox1.Name="textBox1";
            textBox1.ReadOnly=true;
            textBox1.ShortcutsEnabled=false;
            textBox1.Size=new Size(410,37);
            textBox1.TabIndex=5;
            textBox1.TabStop=false;
            textBox1.Text="THÀNH VIÊN NHÓM KN2T:";
            textBox1.WordWrap=false;
            // 
            // tb_title2
            // 
            tb_title2.BackColor=SystemColors.ControlLight;
            tb_title2.BorderStyle=BorderStyle.None;
            tb_title2.Font=new Font("Segoe UI Black",24F,FontStyle.Bold,GraphicsUnit.Point,0);
            tb_title2.ForeColor=Color.Navy;
            tb_title2.Location=new Point(0,155);
            tb_title2.Margin=new Padding(9,11,9,11);
            tb_title2.Multiline=true;
            tb_title2.Name="tb_title2";
            tb_title2.ReadOnly=true;
            tb_title2.ShortcutsEnabled=false;
            tb_title2.Size=new Size(1787,187);
            tb_title2.TabIndex=3;
            tb_title2.TabStop=false;
            tb_title2.TextAlign=HorizontalAlignment.Center;
            tb_title2.WordWrap=false;
            // 
            // tb_title
            // 
            tb_title.BackColor=SystemColors.ControlLight;
            tb_title.BorderStyle=BorderStyle.None;
            tb_title.Font=new Font("Segoe UI Black",22.2F,FontStyle.Bold,GraphicsUnit.Point,0);
            tb_title.ForeColor=Color.DarkRed;
            tb_title.Location=new Point(0,49);
            tb_title.Margin=new Padding(9,11,9,11);
            tb_title.Multiline=true;
            tb_title.Name="tb_title";
            tb_title.ReadOnly=true;
            tb_title.ShortcutsEnabled=false;
            tb_title.Size=new Size(1787,57);
            tb_title.TabIndex=2;
            tb_title.TabStop=false;
            tb_title.TextAlign=HorizontalAlignment.Center;
            tb_title.WordWrap=false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth=ColorDepth.Depth32Bit;
            imageList1.ImageSize=new Size(16,16);
            imageList1.TransparentColor=Color.Transparent;
            // 
            // Menu
            // 
            AutoScaleDimensions=new SizeF(8F,20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1924,1055);
            Controls.Add(panel_Body);
            Controls.Add(panel_Top);
            Controls.Add(panel_Left);
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(3,4,3,4);
            Name="Menu";
            Text="KN2T AIRLINE - TRA CỨU ĐƯỜNG BAY NGẮN NHẤT";
            panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            panel_Body.ResumeLayout(false);
            panel_Body.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Left;
        private Panel panel_Top;
        private Panel panel_Body;
        private Button bt_Manage;
        private Button bt_Show;
        private PictureBox pictureBox1;
        private Label lb_Title;
        private TextBox tb_title;
        private TextBox tb_title2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private TextBox textBox6;
        private TextBox textBox5;
        private ListView listView1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader3;
    }
}
