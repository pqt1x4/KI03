using System.Windows.Forms;

namespace MAINPROJECT
{
    partial class Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            DeleteFlightDeparture=new ComboBox();
            DeleteFlightDestination=new ComboBox();
            aseanMap=new FlowLayoutPanel();
            panel_Control=new Panel();
            bt_offPath=new Button();
            bt_onPath=new Button();
            lb_4=new Label();
            tbStepbyStep=new TextBox();
            lb_3=new Label();
            lb_chiphi=new Label();
            lb_khoangcach=new Label();
            lb_lotrinh=new Label();
            lb_thoigian=new Label();
            lb_2=new Label();
            lb_1=new Label();
            lb_ketthuc=new Label();
            lb_batdau=new Label();
            cbStart=new ComboBox();
            cbEnd=new ComboBox();
            bt_Dijkstra=new Button();
            tbPath=new TextBox();
            tbDistance=new TextBox();
            tbTime=new TextBox();
            tbCost=new TextBox();
            panel_Control.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteFlightDeparture
            // 
            DeleteFlightDeparture.Location=new Point(0,0);
            DeleteFlightDeparture.Name="DeleteFlightDeparture";
            DeleteFlightDeparture.Size=new Size(121,28);
            DeleteFlightDeparture.TabIndex=0;
            // 
            // DeleteFlightDestination
            // 
            DeleteFlightDestination.Location=new Point(0,0);
            DeleteFlightDestination.Name="DeleteFlightDestination";
            DeleteFlightDestination.Size=new Size(121,28);
            DeleteFlightDestination.TabIndex=0;
            // 
            // aseanMap
            // 
            aseanMap.BackColor=Color.Transparent;
            aseanMap.BackgroundImage=(Image)resources.GetObject("aseanMap.BackgroundImage");
            aseanMap.BackgroundImageLayout=ImageLayout.Stretch;
            aseanMap.BorderStyle=BorderStyle.Fixed3D;
            aseanMap.CausesValidation=false;
            aseanMap.Location=new Point(0,0);
            aseanMap.Margin=new Padding(3,4,3,4);
            aseanMap.Name="aseanMap";
            aseanMap.Size=new Size(1440,960);
            aseanMap.TabIndex=6;
            aseanMap.Paint+=aseanMap_Paint;
            // 
            // panel_Control
            // 
            panel_Control.BackColor=Color.FloralWhite;
            panel_Control.BorderStyle=BorderStyle.Fixed3D;
            panel_Control.Controls.Add(bt_offPath);
            panel_Control.Controls.Add(bt_onPath);
            panel_Control.Controls.Add(lb_4);
            panel_Control.Controls.Add(tbStepbyStep);
            panel_Control.Controls.Add(lb_3);
            panel_Control.Controls.Add(lb_chiphi);
            panel_Control.Controls.Add(lb_khoangcach);
            panel_Control.Controls.Add(lb_lotrinh);
            panel_Control.Controls.Add(lb_thoigian);
            panel_Control.Controls.Add(lb_2);
            panel_Control.Controls.Add(lb_1);
            panel_Control.Controls.Add(lb_ketthuc);
            panel_Control.Controls.Add(lb_batdau);
            panel_Control.Controls.Add(cbStart);
            panel_Control.Controls.Add(cbEnd);
            panel_Control.Controls.Add(bt_Dijkstra);
            panel_Control.Controls.Add(tbPath);
            panel_Control.Controls.Add(tbDistance);
            panel_Control.Controls.Add(tbTime);
            panel_Control.Controls.Add(tbCost);
            panel_Control.Dock=DockStyle.Right;
            panel_Control.Location=new Point(1462,0);
            panel_Control.Margin=new Padding(5,4,5,4);
            panel_Control.Name="panel_Control";
            panel_Control.Size=new Size(319,1054);
            panel_Control.TabIndex=10;
            panel_Control.Paint+=panel_Control_Paint;
            // 
            // bt_offPath
            // 
            bt_offPath.BackColor=Color.LightCoral;
            bt_offPath.Font=new Font("Microsoft Sans Serif",8.25F,FontStyle.Bold);
            bt_offPath.Location=new Point(263,942);
            bt_offPath.Margin=new Padding(2,3,2,3);
            bt_offPath.Name="bt_offPath";
            bt_offPath.Size=new Size(47,33);
            bt_offPath.TabIndex=20;
            bt_offPath.Text="TẮT";
            bt_offPath.UseVisualStyleBackColor=false;
            bt_offPath.Click+=bt_offPath_Click;
            // 
            // bt_onPath
            // 
            bt_onPath.BackColor=Color.PaleGreen;
            bt_onPath.Font=new Font("Microsoft Sans Serif",8.25F,FontStyle.Bold);
            bt_onPath.Location=new Point(205,942);
            bt_onPath.Margin=new Padding(2,3,2,3);
            bt_onPath.Name="bt_onPath";
            bt_onPath.Size=new Size(51,33);
            bt_onPath.TabIndex=19;
            bt_onPath.Text="BẬT";
            bt_onPath.TextImageRelation=TextImageRelation.TextBeforeImage;
            bt_onPath.UseVisualStyleBackColor=false;
            bt_onPath.Click+=bt_onPath_Click;
            // 
            // lb_4
            // 
            lb_4.Font=new Font("Calibri",9.75F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_4.Location=new Point(5,949);
            lb_4.Margin=new Padding(5,0,5,0);
            lb_4.Name="lb_4";
            lb_4.Size=new Size(199,36);
            lb_4.TabIndex=43;
            lb_4.Text="HIỂN THỊ TẤT CẢ ĐƯỜNG BAY";
            lb_4.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // tbStepbyStep
            // 
            tbStepbyStep.BackColor=SystemColors.Info;
            tbStepbyStep.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            tbStepbyStep.Location=new Point(-2,645);
            tbStepbyStep.Margin=new Padding(5,4,5,4);
            tbStepbyStep.Multiline=true;
            tbStepbyStep.Name="tbStepbyStep";
            tbStepbyStep.ScrollBars=ScrollBars.Vertical;
            tbStepbyStep.Size=new Size(318,295);
            tbStepbyStep.TabIndex=42;
            // 
            // lb_3
            // 
            lb_3.BackColor=Color.LightSteelBlue;
            lb_3.BorderStyle=BorderStyle.FixedSingle;
            lb_3.Font=new Font("Segoe UI Black",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_3.ForeColor=SystemColors.ActiveCaptionText;
            lb_3.Location=new Point(-2,577);
            lb_3.Margin=new Padding(5,0,5,0);
            lb_3.Name="lb_3";
            lb_3.Size=new Size(319,34);
            lb_3.TabIndex=41;
            lb_3.Text="THIẾT LẬP CHẾ ĐỘ XEM";
            lb_3.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // lb_chiphi
            // 
            lb_chiphi.Font=new Font("Segoe UI Black",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_chiphi.Location=new Point(10,204);
            lb_chiphi.Margin=new Padding(5,0,5,0);
            lb_chiphi.Name="lb_chiphi";
            lb_chiphi.Size=new Size(222,37);
            lb_chiphi.TabIndex=40;
            lb_chiphi.Text="Chi phí (Một chuyến):";
            lb_chiphi.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // lb_khoangcach
            // 
            lb_khoangcach.Font=new Font("Segoe UI Black",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_khoangcach.Location=new Point(10,351);
            lb_khoangcach.Margin=new Padding(5,0,5,0);
            lb_khoangcach.Name="lb_khoangcach";
            lb_khoangcach.Size=new Size(254,37);
            lb_khoangcach.TabIndex=39;
            lb_khoangcach.Text="Khoảng cách:";
            lb_khoangcach.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // lb_lotrinh
            // 
            lb_lotrinh.Font=new Font("Segoe UI Black",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_lotrinh.Location=new Point(14,424);
            lb_lotrinh.Margin=new Padding(5,0,5,0);
            lb_lotrinh.Name="lb_lotrinh";
            lb_lotrinh.Size=new Size(96,37);
            lb_lotrinh.TabIndex=38;
            lb_lotrinh.Text="Lộ trình:";
            lb_lotrinh.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // lb_thoigian
            // 
            lb_thoigian.Font=new Font("Segoe UI Black",11.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_thoigian.Location=new Point(10,277);
            lb_thoigian.Margin=new Padding(5,0,5,0);
            lb_thoigian.Name="lb_thoigian";
            lb_thoigian.Size=new Size(146,37);
            lb_thoigian.TabIndex=37;
            lb_thoigian.Text="Thời gian:";
            lb_thoigian.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // lb_2
            // 
            lb_2.BackColor=Color.Aquamarine;
            lb_2.BorderStyle=BorderStyle.FixedSingle;
            lb_2.Font=new Font("Segoe UI Black",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_2.ForeColor=SystemColors.ActiveCaptionText;
            lb_2.Location=new Point(-2,155);
            lb_2.Margin=new Padding(5,0,5,0);
            lb_2.Name="lb_2";
            lb_2.Size=new Size(319,46);
            lb_2.TabIndex=36;
            lb_2.Text="THÔNG TIN ĐƯỜNG BAY";
            lb_2.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // lb_1
            // 
            lb_1.BackColor=Color.Salmon;
            lb_1.BorderStyle=BorderStyle.FixedSingle;
            lb_1.Font=new Font("Segoe UI Black",12F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_1.ForeColor=Color.White;
            lb_1.Location=new Point(-2,0);
            lb_1.Margin=new Padding(5,0,5,0);
            lb_1.Name="lb_1";
            lb_1.Size=new Size(319,46);
            lb_1.TabIndex=35;
            lb_1.Text="LỰA CHỌN ĐƯỜNG BAY";
            lb_1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // lb_ketthuc
            // 
            lb_ketthuc.Font=new Font("Segoe UI Black",14.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_ketthuc.ForeColor=Color.FromArgb(0,0,192);
            lb_ketthuc.Location=new Point(11,107);
            lb_ketthuc.Margin=new Padding(5,0,5,0);
            lb_ketthuc.Name="lb_ketthuc";
            lb_ketthuc.Size=new Size(137,37);
            lb_ketthuc.TabIndex=34;
            lb_ketthuc.Text="ĐIỂM ĐẾN";
            lb_ketthuc.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // lb_batdau
            // 
            lb_batdau.Font=new Font("Segoe UI Black",14.25F,FontStyle.Bold,GraphicsUnit.Point,0);
            lb_batdau.ForeColor=Color.FromArgb(0,0,192);
            lb_batdau.Location=new Point(14,55);
            lb_batdau.Margin=new Padding(5,0,5,0);
            lb_batdau.Name="lb_batdau";
            lb_batdau.Size=new Size(137,37);
            lb_batdau.TabIndex=4;
            lb_batdau.Text="ĐIỂM ĐI";
            lb_batdau.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // cbStart
            // 
            cbStart.BackColor=SystemColors.Info;
            cbStart.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            cbStart.FormattingEnabled=true;
            cbStart.Location=new Point(160,55);
            cbStart.Margin=new Padding(5,4,5,4);
            cbStart.Name="cbStart";
            cbStart.Size=new Size(149,33);
            cbStart.TabIndex=1;
            cbStart.SelectedIndexChanged+=cbStart_SelectedIndexChanged;
            // 
            // cbEnd
            // 
            cbEnd.BackColor=SystemColors.Info;
            cbEnd.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            cbEnd.FormattingEnabled=true;
            cbEnd.Location=new Point(160,107);
            cbEnd.Margin=new Padding(5,4,5,4);
            cbEnd.Name="cbEnd";
            cbEnd.Size=new Size(149,33);
            cbEnd.TabIndex=7;
            cbEnd.SelectedIndexChanged+=cbEnd_SelectedIndexChanged;
            // 
            // bt_Dijkstra
            // 
            bt_Dijkstra.Font=new Font("Segoe UI Semibold",7.8F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_Dijkstra.ImageAlign=ContentAlignment.TopCenter;
            bt_Dijkstra.Location=new Point(8,614);
            bt_Dijkstra.Margin=new Padding(2,3,2,3);
            bt_Dijkstra.Name="bt_Dijkstra";
            bt_Dijkstra.Size=new Size(297,28);
            bt_Dijkstra.TabIndex=27;
            bt_Dijkstra.Text="MINH HỌA THUẬT TOÁN DIJKTRA";
            bt_Dijkstra.UseVisualStyleBackColor=true;
            bt_Dijkstra.Click+=StepByStepButton_Click;
            // 
            // tbPath
            // 
            tbPath.BackColor=SystemColors.Info;
            tbPath.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            tbPath.Location=new Point(10,461);
            tbPath.Margin=new Padding(5,4,5,4);
            tbPath.Multiline=true;
            tbPath.Name="tbPath";
            tbPath.Size=new Size(297,104);
            tbPath.TabIndex=8;
            // 
            // tbDistance
            // 
            tbDistance.BackColor=SystemColors.Info;
            tbDistance.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            tbDistance.Location=new Point(10,388);
            tbDistance.Margin=new Padding(5,4,5,4);
            tbDistance.Name="tbDistance";
            tbDistance.Size=new Size(193,32);
            tbDistance.TabIndex=11;
            tbDistance.TextAlign=HorizontalAlignment.Right;
            // 
            // tbTime
            // 
            tbTime.BackColor=SystemColors.Info;
            tbTime.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            tbTime.Location=new Point(10,315);
            tbTime.Margin=new Padding(5,4,5,4);
            tbTime.Name="tbTime";
            tbTime.Size=new Size(193,32);
            tbTime.TabIndex=9;
            tbTime.TextAlign=HorizontalAlignment.Right;
            // 
            // tbCost
            // 
            tbCost.BackColor=SystemColors.Info;
            tbCost.Font=new Font("Segoe UI",11.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            tbCost.Location=new Point(10,241);
            tbCost.Margin=new Padding(5,4,5,4);
            tbCost.Name="tbCost";
            tbCost.Size=new Size(193,32);
            tbCost.TabIndex=7;
            tbCost.TextAlign=HorizontalAlignment.Right;
            // 
            // Show
            // 
            AutoScaleDimensions=new SizeF(8F,20F);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            BackColor=Color.FromArgb(192,192,255);
            ClientSize=new Size(1781,1054);
            Controls.Add(aseanMap);
            Controls.Add(panel_Control);
            Margin=new Padding(5,4,5,4);
            Name="Show";
            Load+=Form1_Load;
            panel_Control.ResumeLayout(false);
            panel_Control.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.ColumnHeader clPoint;
        private System.Windows.Forms.PictureBoxSizeMode logo;
        private FlowLayoutPanel aseanMap;
        private TextBox tbCost;
        private TextBox tbTime;
        private TextBox tbDistance;
        private TextBox tbPath;
        private Button bt_Dijkstra;
        private ComboBox cbEnd;
        private ComboBox DeleteFlightDeparture;
        private ComboBox cbStart;
        private Label label8;
        private Label lb_batdau;
        private ComboBox DeleteFlightDestination;
        private Label lb_ketthuc;
        private Label lb_1;
        private Label lb_2;
        private Label lb_thoigian;
        private Label lb_lotrinh;
        private Label lb_khoangcach;
        private Label lb_chiphi;
        private Label lb_3;
        private Panel panel_Control;
        private TextBox tbStepbyStep;
        private Label lb_4;
        private Button bt_offPath;
        private Button bt_onPath;
    }
}
