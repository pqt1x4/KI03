namespace MAINPROJECT
{
    partial class Manage
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
            lsvShow=new ListView();
            columnHeader1=new ColumnHeader();
            columnHeader2=new ColumnHeader();
            columnHeader3=new ColumnHeader();
            panel_Control=new Panel();
            bt_Remove=new Button();
            bt_Update=new Button();
            bt_AddNew=new Button();
            cb_Distance=new TextBox();
            label6=new Label();
            cb_End=new ComboBox();
            cb_Start=new ComboBox();
            label2=new Label();
            label5=new Label();
            label_1=new Label();
            panel_Control.SuspendLayout();
            SuspendLayout();
            // 
            // lsvShow
            // 
            lsvShow.BackColor=SystemColors.InactiveBorder;
            lsvShow.Columns.AddRange(new ColumnHeader[] { columnHeader1,columnHeader2,columnHeader3 });
            lsvShow.Dock=DockStyle.Left;
            lsvShow.Font=new Font("Segoe UI",13.8F,FontStyle.Bold,GraphicsUnit.Point,0);
            lsvShow.GridLines=true;
            lsvShow.HeaderStyle=ColumnHeaderStyle.Nonclickable;
            lsvShow.Location=new Point(0,0);
            lsvShow.Margin=new Padding(3,4,3,4);
            lsvShow.MultiSelect=false;
            lsvShow.Name="lsvShow";
            lsvShow.ShowGroups=false;
            lsvShow.Size=new Size(605,783);
            lsvShow.TabIndex=1;
            lsvShow.UseCompatibleStateImageBehavior=false;
            lsvShow.View=View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text="ĐIỂM ĐI";
            columnHeader1.Width=150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text="ĐIỂM ĐẾN";
            columnHeader2.Width=150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text="KHOẢNG CÁCH";
            columnHeader3.TextAlign=HorizontalAlignment.Center;
            columnHeader3.Width=200;
            // 
            // panel_Control
            // 
            panel_Control.BackColor=Color.PapayaWhip;
            panel_Control.BorderStyle=BorderStyle.Fixed3D;
            panel_Control.Controls.Add(bt_Remove);
            panel_Control.Controls.Add(bt_Update);
            panel_Control.Controls.Add(bt_AddNew);
            panel_Control.Controls.Add(cb_Distance);
            panel_Control.Controls.Add(label6);
            panel_Control.Controls.Add(cb_End);
            panel_Control.Controls.Add(cb_Start);
            panel_Control.Controls.Add(label2);
            panel_Control.Controls.Add(label5);
            panel_Control.Controls.Add(label_1);
            panel_Control.Dock=DockStyle.Left;
            panel_Control.Location=new Point(605,0);
            panel_Control.Margin=new Padding(3,4,3,4);
            panel_Control.Name="panel_Control";
            panel_Control.Size=new Size(730,783);
            panel_Control.TabIndex=2;
            // 
            // bt_Remove
            // 
            bt_Remove.BackColor=Color.FromArgb(255,128,128);
            bt_Remove.Font=new Font("Segoe UI Black",13.8F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_Remove.Location=new Point(32,655);
            bt_Remove.Margin=new Padding(3,4,3,4);
            bt_Remove.Name="bt_Remove";
            bt_Remove.Size=new Size(664,61);
            bt_Remove.TabIndex=49;
            bt_Remove.Text="XÓA ĐƯỜNG BAY";
            bt_Remove.UseVisualStyleBackColor=false;
            bt_Remove.Click+=bt_Remove_Click;
            // 
            // bt_Update
            // 
            bt_Update.BackColor=Color.FromArgb(255,255,128);
            bt_Update.Font=new Font("Segoe UI Black",13.8F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_Update.Location=new Point(32,549);
            bt_Update.Margin=new Padding(3,4,3,4);
            bt_Update.Name="bt_Update";
            bt_Update.Size=new Size(664,61);
            bt_Update.TabIndex=48;
            bt_Update.Text="CẬP NHẬT ĐƯỜNG BAY";
            bt_Update.UseVisualStyleBackColor=false;
            bt_Update.Click+=bt_Update_Click;
            // 
            // bt_AddNew
            // 
            bt_AddNew.BackColor=Color.FromArgb(128,255,128);
            bt_AddNew.Font=new Font("Segoe UI Black",13.8F,FontStyle.Bold,GraphicsUnit.Point,0);
            bt_AddNew.Location=new Point(32,443);
            bt_AddNew.Margin=new Padding(3,4,3,4);
            bt_AddNew.Name="bt_AddNew";
            bt_AddNew.Size=new Size(664,61);
            bt_AddNew.TabIndex=47;
            bt_AddNew.Text="MỞ ĐƯỜNG BAY MỚI";
            bt_AddNew.UseVisualStyleBackColor=false;
            bt_AddNew.Click+=bt_AddNew_Click;
            // 
            // cb_Distance
            // 
            cb_Distance.Font=new Font("Segoe UI",14.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_Distance.Location=new Point(362,295);
            cb_Distance.Margin=new Padding(3,4,3,4);
            cb_Distance.Name="cb_Distance";
            cb_Distance.Size=new Size(217,39);
            cb_Distance.TabIndex=46;
            cb_Distance.KeyPress+=cb_Distance_KeyPress;
            // 
            // label6
            // 
            label6.Font=new Font("Segoe UI Black",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label6.ForeColor=Color.FromArgb(0,0,192);
            label6.Location=new Point(32,293);
            label6.Margin=new Padding(5,0,5,0);
            label6.Name="label6";
            label6.Size=new Size(303,37);
            label6.TabIndex=44;
            label6.Text="KHOẢNG CÁCH (KM)";
            label6.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // cb_End
            // 
            cb_End.BackColor=SystemColors.Info;
            cb_End.Font=new Font("Segoe UI",14.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_End.FormattingEnabled=true;
            cb_End.Location=new Point(362,198);
            cb_End.Margin=new Padding(5,4,5,4);
            cb_End.Name="cb_End";
            cb_End.Size=new Size(217,40);
            cb_End.TabIndex=40;
            cb_End.SelectedIndexChanged+=cb_End_SelectedIndexChanged;
            // 
            // cb_Start
            // 
            cb_Start.BackColor=SystemColors.Info;
            cb_Start.Font=new Font("Segoe UI",14.25F,FontStyle.Regular,GraphicsUnit.Point,0);
            cb_Start.FormattingEnabled=true;
            cb_Start.Location=new Point(362,105);
            cb_Start.Margin=new Padding(5,4,5,4);
            cb_Start.Name="cb_Start";
            cb_Start.Size=new Size(217,40);
            cb_Start.TabIndex=39;
            cb_Start.SelectedIndexChanged+=cb_Start_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font=new Font("Segoe UI Black",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label2.ForeColor=Color.FromArgb(0,0,192);
            label2.Location=new Point(32,196);
            label2.Margin=new Padding(5,0,5,0);
            label2.Name="label2";
            label2.Size=new Size(283,37);
            label2.TabIndex=38;
            label2.Text="ĐIỂM ĐẾN";
            label2.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font=new Font("Segoe UI Black",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label5.ForeColor=Color.FromArgb(0,0,192);
            label5.Location=new Point(32,103);
            label5.Margin=new Padding(5,0,5,0);
            label5.Name="label5";
            label5.Size=new Size(249,37);
            label5.TabIndex=37;
            label5.Text="ĐIỂM ĐI";
            label5.TextAlign=ContentAlignment.MiddleLeft;
            // 
            // label_1
            // 
            label_1.BackColor=Color.MidnightBlue;
            label_1.BorderStyle=BorderStyle.FixedSingle;
            label_1.Font=new Font("Segoe UI",18F,FontStyle.Bold,GraphicsUnit.Point,0);
            label_1.ForeColor=Color.White;
            label_1.Location=new Point(-2,0);
            label_1.Margin=new Padding(5,0,5,0);
            label_1.Name="label_1";
            label_1.Size=new Size(730,66);
            label_1.TabIndex=36;
            label_1.Text="NHẬP THÔNG TIN CẦN THAY ĐỔI";
            label_1.TextAlign=ContentAlignment.MiddleCenter;
            // 
            // Manage
            // 
            AutoScaleDimensions=new SizeF(8F,20F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(255,128,128);
            ClientSize=new Size(1566,783);
            Controls.Add(panel_Control);
            Controls.Add(lsvShow);
            Margin=new Padding(3,4,3,4);
            Name="Manage";
            Text="Form1";
            Load+=Manage_Load;
            panel_Control.ResumeLayout(false);
            panel_Control.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView lsvShow;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Panel panel_Control;
        private Label label_1;
        private Label label2;
        private Label label5;
        private ComboBox cb_End;
        private ComboBox cb_Start;
        private Label label6;
        private TextBox cb_Distance;
        private Button bt_AddNew;
        private Button bt_Remove;
        private Button bt_Update;
    }
}