using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MAINPROJECT
{
    public partial class Show : Form
    {
        public List<Location> Locations = new List<Location>();
        public List<Edge> EdgesSend = new List<Edge>();
        public List<Edge> Edges = new List<Edge>();
        SetUpGraph g = new SetUpGraph();
        bool PathControl = true;

        public Show(List<Edge> EdgesSend)
        {
            InitializeComponent();
            this.EdgesSend = EdgesSend;
        }

        private void Form1_Load(object creator, EventArgs e)
        {
            //Khoi tao cac vi tri cac thu do cua cac quoc gia tuong ung tren ban do Asean.
            Graphics graph = aseanMap.CreateGraphics();
            float map_width = ((float)aseanMap.Width / 870.0f); //Default 870
            float map_height = ((float)aseanMap.Height / 580.0f);  //Default 580 
            Location Vietnam = new Location("Vietnam", "V", (int)Math.Round(map_width * 248.0f), (int)Math.Round(map_height * 105.0f));
            Location Cambodia = new Location("Cambodia", "C", (int)Math.Round(map_width * 237.0f), (int)Math.Round(map_height * 248.0f));
            Location Laos = new Location("Laos", "L", (int)Math.Round(map_width * 195.0f), (int)Math.Round(map_height * 157.0f));
            Location Thailand = new Location("Thailand", "T", (int)Math.Round(map_width * 155.0f), (int)Math.Round(map_height * 225.0f));
            Location Myanmar = new Location("Myanmar", "M", (int)Math.Round(map_width * 88.0f), (int)Math.Round(map_height * 187.0f));
            Location Malaysia = new Location("Malaysia", "Ma", (int)Math.Round(map_width * 195.0f), (int)Math.Round(map_height * 385.0f));
            Location Singapore = new Location("Singapore", "S", (int)Math.Round(map_width * 247.0f), (int)Math.Round(map_height * 414.0f));
            Location Indonesia = new Location("Indonesia", "I", (int)Math.Round(map_width * 300.0f), (int)Math.Round(map_height * 523.0f));
            Location Brunei = new Location("Brunei", "B", (int)Math.Round(map_width * 388.0f), (int)Math.Round(map_height * 352.0f));
            Location Philippines = new Location("Philippines", "P", (int)Math.Round(map_width * 514.0f), (int)Math.Round(map_height * 184.0f));
            Location Timor_Leste = new Location("Timor-Leste", "Ti", (int)Math.Round(map_width * 615.0f), (int)Math.Round(map_height * 535.0f));

            //Them cac vi tri vao danh sach Locations theo thu tu alphabet
            Locations.Add(Brunei);
            Locations.Add(Cambodia);
            Locations.Add(Indonesia);
            Locations.Add(Laos);
            Locations.Add(Malaysia);
            Locations.Add(Myanmar);
            Locations.Add(Philippines);
            Locations.Add(Singapore);
            Locations.Add(Thailand);
            Locations.Add(Timor_Leste);
            Locations.Add(Vietnam);

            //Them cac vi tri vao danh sach vao combobox cbStart
            cbStart.Items.Add("Brunei");
            cbStart.Items.Add("Cambodia");
            cbStart.Items.Add("Indonesia");
            cbStart.Items.Add("Laos");
            cbStart.Items.Add("Malaysia");
            cbStart.Items.Add("Myanmar");
            cbStart.Items.Add("Philippines");
            cbStart.Items.Add("Singapore");
            cbStart.Items.Add("Thailand");
            cbStart.Items.Add("Timor-Leste");
            cbStart.Items.Add("Vietnam");

            //Them cac vi tri cac quoc gia vao combobox cbEnd
            cbEnd.Items.Add("Brunei");
            cbEnd.Items.Add("Cambodia");
            cbEnd.Items.Add("Indonesia");
            cbEnd.Items.Add("Laos");
            cbEnd.Items.Add("Malaysia");
            cbEnd.Items.Add("Myanmar");
            cbEnd.Items.Add("Philippines");
            cbEnd.Items.Add("Singapore");
            cbEnd.Items.Add("Thailand");
            cbEnd.Items.Add("Timor-Leste");
            cbEnd.Items.Add("Vietnam");

            //Lay canh tu Menu.
            Edges = EdgesSend;

            for (int i = 0; i < Locations.Count; i++)
            {
                g.listPoint.Add(Locations[i].getPoint());
                g.InsertVertex(Locations[i].getName());
            }
            for (int i = 0; i < Edges.Count; i++)
            {
                g.InsertEdge(Edges[i].getDeparture().ToString(), Edges[i].getDestination().ToString(), Edges[i].getKilometer());
            }
            bt_onPath.Enabled = false;
            DrawAllEdge();
        }
        private void panel_Control_Paint(object sender, PaintEventArgs e)
        {
            //if (PathControl)
            //    DrawAllEdge();
        }

        private void aseanMap_Paint(object sender, PaintEventArgs e)
        {
            if (PathControl)
                DrawAllEdge();
        }

        // Ve tat ca cac canh ra man hinh
        private void DrawAllEdge()
        {
            for (int i = 0; i < Edges.Count; i++)
                DrawEdge(Edges[i].getDeparture(), Edges[i].getDestination());
        }
        // Noi va ve canh dinh a va dinh b ra man hinh
        private void DrawEdge(string a, string b)
        {
            Graphics graph = aseanMap.CreateGraphics();

            int x = g.GetIndex(a);
            int y = g.GetIndex(b);

            Pen p = new Pen(Color.LightGray, 2);
            Color semiTransparentColor = Color.FromArgb(128, 255, 0, 0);
            Brush backgroundBrush = Brushes.LightBlue;

            System.Drawing.Font font = new System.Drawing.Font("Fira Code", 6);

            Point point1 = new Point(g.listPoint[x].X, g.listPoint[x].Y);
            Point point2 = new Point(g.listPoint[y].X, g.listPoint[y].Y);


            SizeF textSize = graph.MeasureString($"{g.adj[x, y]}", font);
            RectangleF textRectangle = new RectangleF(new Point((point1.X + point2.X - (int)Math.Ceiling(textSize.Width)) / 2, (point1.Y + point2.Y - (int)Math.Ceiling(textSize.Height)) / 2), textSize);

            graph.DrawLine(p, point1, point2);
            graph.FillRectangle(backgroundBrush, textRectangle);
            graph.DrawString($"{g.adj[x, y]}", font, Brushes.Blue, new Point((point1.X + point2.X - (int)Math.Ceiling(textSize.Width)) / 2, (point1.Y + point2.Y - (int)Math.Ceiling(textSize.Height)) / 2));

        }

        //Tim kiem duong di
        private void cbStart_SelectedIndexChanged(object creator, EventArgs e)
        {
            if (cbStart.SelectedIndex != -1 && cbEnd.SelectedIndex != -1 && (cbStart.SelectedIndex != cbEnd.SelectedIndex))
            {
                aseanMap.Controls.Clear();
                aseanMap.Refresh();
                if (PathControl)
                    DrawAllEdge();
                g.pathIndex.Clear();
                tbDistance.Clear();
                tbTime.Clear();
                tbCost.Clear();
                tbPath.Clear();
                g.FindPaths(cbStart.SelectedItem.ToString(), cbEnd.SelectedIndex.ToString(), tbDistance, tbTime, tbCost, tbPath);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbStart.SelectedIndex == cbEnd.SelectedIndex)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
            }
        }
        private void cbEnd_SelectedIndexChanged(object creator, EventArgs e)
        {
            if (cbStart.SelectedIndex != -1 && cbEnd.SelectedIndex != -1)
            {
                aseanMap.Controls.Clear();
                aseanMap.Refresh();
                if (PathControl)
                    DrawAllEdge();
                g.pathIndex.Clear();
                tbDistance.Clear();
                tbTime.Clear();
                tbCost.Clear();
                tbPath.Clear();
                g.FindPaths(cbStart.SelectedItem.ToString(), cbEnd.SelectedIndex.ToString(), tbDistance, tbTime, tbCost, tbPath);
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbStart.SelectedIndex == cbEnd.SelectedIndex)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
            }
        }
        //Minh hoa thuat toan Dijkstra
        private void StepByStepButton_Click(object sender, EventArgs e)
        {
            if (cbStart.SelectedIndex != -1 && cbEnd.SelectedIndex != -1 && (cbStart.SelectedIndex != cbEnd.SelectedIndex))
            {
                aseanMap.Controls.Clear();
                aseanMap.Refresh();
                if (PathControl)
                    DrawAllEdge();
                g.pathIndex.Clear();
                g.listPointStep.Clear();
                tbDistance.Clear();
                tbTime.Clear();
                tbCost.Clear();
                tbPath.Clear();
                g.FindPaths(cbStart.SelectedItem.ToString(), cbEnd.SelectedIndex.ToString(), tbDistance, tbTime, tbCost, tbPath);
                tbStepbyStep.Clear();
                g.ShowFindPaths(cbStart.SelectedItem.ToString(), cbEnd.SelectedIndex.ToString(), tbStepbyStep);
                Point now = new Point(0, 0);
                int numPathFind = 0;
                for (int i = 0; i < g.listPointStep.Count - 1; i++)
                {
                    List<Point> lpoint = g.listPointStep[i];
                    if (g.listPointStep[i].Count > 0)
                    {
                        now.X = g.listPointStep[i][0].X;
                        now.Y = g.listPointStep[i][0].Y;
                    }
                    for (int j = 0; j < lpoint.Count - 1; j = j + 2)
                    {
                        DrawPathLineShow(i, j, now, numPathFind);
                        System.Threading.Thread.Sleep(500);
                    }
                }
                for (int i = 0; i < g.pathIndex.Count - 1; i++)
                {
                    DrawPathLine(i);
                }
            }
            if (cbStart.SelectedIndex == cbEnd.SelectedIndex)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
            }
        }
        //Ve duong di ngan nhat Dijkstra
        private void DrawPathLine(int i)
        {
            Graphics graph = aseanMap.CreateGraphics();
            Pen p = new Pen(Color.DarkGreen, 3);
            Point point1 = new Point(g.pathIndex[i].X, g.pathIndex[i].Y);
            Point point2 = new Point(g.pathIndex[i + 1].X, g.pathIndex[i + 1].Y);
            graph.DrawLine(p, point1, point2);
        }
        //Ve duong di minh hoa Dijkstra
        private void DrawPathLineShow(int i, int j, Point now, int numPathFind)
        {
            if (i >= 0 && i < g.listPointStep.Count && j >= 0 && j < g.listPointStep[i].Count)
            {
                Graphics graph = aseanMap.CreateGraphics();
                Pen p = new Pen(Color.BlueViolet, 2);
                List<Point> lpoint = g.listPointStep[i];
                Point point1 = new Point(lpoint[j].X, lpoint[j].Y);
                Point point2 = new Point(lpoint[j + 1].X, lpoint[j + 1].Y);
                graph.DrawLine(p, point1, point2);
            }
        }
        //Bat pathline:
        private void bt_onPath_Click(object sender, EventArgs e)
        {
            aseanMap.Refresh();
            PathControl = true;
            DrawAllEdge();
            bt_onPath.Enabled = false;
            bt_offPath.Enabled = true;
        }
        //Tat pathline:
        private void bt_offPath_Click(object sender, EventArgs e)
        {
            aseanMap.Refresh();
            PathControl = false;
            bt_onPath.Click -= bt_onPath_Click;
            aseanMap.Invalidate();
            bt_onPath.Click += bt_onPath_Click;
            bt_offPath.Enabled = false;
            bt_onPath.Enabled = true;
        }
    }
}
