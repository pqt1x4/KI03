using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAINPROJECT
{
    // CLASS EDGE
    public class Edge
    {
        private string departure { get; set; }
        private string destination { get; set; }
        private int kilometer { get; set; }
        public Edge(string _departure, string _destination, int _kilometer)
        {
            departure = _departure;
            destination = _destination;
            kilometer = _kilometer;
        }
        public string getDeparture()
        {
            return departure;
        }
        public string getDestination()
        {
            return destination;
        }

        public int getKilometer()
        {

            return kilometer;
        }
        public void setKilometers(int _kilometers)
        {
            kilometer = _kilometers;
        }
    }
    // CLASS LOCATION
    public class Location
    {
        private string nameLocation { get; set; }
        private string pointName { get; set; }
        private Point pointLocation { get; set; }

        public Location(string name, string symbol, int x, int y)
        {
            nameLocation = name;
            pointName = symbol;
            Point p = new Point(x, y);
            pointLocation = p;
        }
        public string getName()
        {
            return nameLocation;
        }
        public string getPointName()
        {
            return pointName;
        }
        public Point getPoint()
        {
            return pointLocation;
        }
    }
    // CLASS VERTEX 
    public class Vertex
    {
        public String name;
        public int status;
        public int predecessor;
        public int pathLength;
        public Vertex(String name)
        {
            this.name = name;
        }
    }

    class SetUpGraph
    {
        //Khoi tao cac hang so phuc vu cho thuat toan Dijkstra:
            //So canh toi da
        public readonly int MAX_VERTICES = 100;
            //Quy uoc vo cung
        private readonly int INFINITY = 9999999;
            //Quy uoc trang thai da tham
        private readonly int PERMANENT = 2;
            //Quy uoc trang thai chua tham
        private readonly int TEMPORARY = 1;
            //Quy uoc chi so rong cho thanh phan phia truoc
        private readonly int NIL = -1;
            //n la so dinh
        public int n = 0;
            //Ma tran ke
        public int[,] adj;

        //Danh sach ten cac dinh
        public Vertex[] vertexList;
        //Danh sach vi tri dinh
        public List<Point> listPoint = new List<Point>();
        //Danh sach duong di cho Dijkstra
        public List<Point> pathIndex = new List<Point>();
        //Danh sach duong di mo ta Dijkstra
        public List<List<Point>> listPointStep = new List<List<Point>>();

        public SetUpGraph()
        {
            adj = new int[MAX_VERTICES, MAX_VERTICES];
            vertexList = new Vertex[MAX_VERTICES];
        }
        // KẾT QUẢ CỦA DIJKSTRA
        private void DijkstraShow(string source, string last, TextBox tbStepbyStep)
        {
            int s = GetIndex(source);
            int v, c;
            List<Point> temp = new List<Point>();
            for (v = 0; v < n; v++)
            {
                vertexList[v].status = TEMPORARY;
                vertexList[v].pathLength = INFINITY;
                vertexList[v].predecessor = NIL;
            }
            vertexList[s].pathLength = 0;

            while (true)
            {
                List<Point> temp2 = new List<Point>();
                int k = listPointStep.Count;
                c = TempVertex();
                int number = c;
                if (c >= 0 && c < n)
                {
                    tbStepbyStep.Text += $"Step {k}: Choose " + $"{vertexList[c].name}" + "\r\n";
                }
                if (c == NIL)
                    return;
                vertexList[c].status = PERMANENT;

                for (v = 0; v < n; v++)
                {
                    if (IsAdjacent(c, v) && vertexList[v].status == TEMPORARY)
                    {
                        if (vertexList[c].pathLength + adj[c, v] < vertexList[v].pathLength)
                        {
                            tbStepbyStep.Text += "[" + vertexList[c].name + "," + vertexList[v].name + "]";
                            vertexList[v].predecessor = c;
                            vertexList[v].pathLength = vertexList[c].pathLength + adj[c, v];
                            tbStepbyStep.Text += "={" + $"{vertexList[v].pathLength}" + "}" + "\r\n";
                            temp2.Add(listPoint[c]);
                            temp2.Add(listPoint[v]);
                        }
                    }
                }
                listPointStep.Add(temp2);
            }
        }
        public void ShowFindPaths(string source, string last, TextBox tbStepbyStep)
        {
            if (source == last)
            {
                MessageBox.Show("Error!", "Notify!");
            }
            else
            {
                DijkstraShow(source, last, tbStepbyStep);
            }
        }
        // HÀM DIJKSTRA
        private void Dijkstra(int s)
        {
            int v, c;
            for (v = 0; v < n; v++)
            {
                vertexList[v].status = TEMPORARY;
                vertexList[v].pathLength = INFINITY;
                vertexList[v].predecessor = NIL;
            }
            vertexList[s].pathLength = 0;
            while (true)
            {
                c = TempVertex();
                if (c == NIL)
                    return;
                vertexList[c].status = PERMANENT;
                for (v = 0; v < n; v++)
                {
                    if (IsAdjacent(c, v) && vertexList[v].status == TEMPORARY)
                    {
                        if (vertexList[c].pathLength + adj[c, v] < vertexList[v].pathLength)
                        {
                            vertexList[v].predecessor = c;
                            vertexList[v].pathLength = vertexList[c].pathLength + adj[c, v];
                        }
                    }
                }
            }
        }
        public void FindPaths(string source, string last, TextBox tbDistance, TextBox tbLiter, TextBox tbCost, TextBox tbPath)
        {
            int s = GetIndex(source);
            Dijkstra(s);

            int v = Convert.ToInt32(last);
            {
                if (v != s)
                {
                    if (vertexList[v].pathLength == INFINITY)
                    {
                        tbPath.Text = "Không có đường đi";
                    }
                    else
                    {
                        FindPath(s, v, tbDistance, tbLiter, tbCost, tbPath);
                    }
                }
            }
        }
        // HÀM TÍNH TOÁN CÁC THUỘC TÍNH CỦA ĐƯỜNG BAY
        public void FindPath(int s, int v, TextBox tbDistance, TextBox tbTime, TextBox tbCost, TextBox tbPath)
        {
            int i, u;
            int[] path = new int[n];
            int km = 0;
            int count = 0;
            while (v != s)
            {
                count++;
                path[count] = v;
                u = vertexList[v].predecessor;
                km += adj[u, v];
                v = u;
            }
            double time = Math.Round(km/793.0d,1);
            int sd = km * 3528;

            count++;
            if (count >= n)
            {
                MessageBox.Show("Error!", "Notify!");

            }
            path[count] = s;
            for (i = count; i >= 1; i--)
            {
                pathIndex.Add(listPoint[path[i]]);
                if (tbPath.Text == "")
                {
                    tbPath.Text += vertexList[path[i]].name;
                }
                else
                {
                    tbPath.Text += " -> " + vertexList[path[i]].name;
                }
            }
            tbDistance.Text = $"{km} KM";
            tbTime.Text = $"{time} giờ";
            tbCost.Text = $"{sd} VNĐ";
        }

        public int GetIndex(string s)
        {
            for (int i = 0; i < n; i++)
            {
                if (s.Equals(vertexList[i].name))
                    return i;
            }
            throw new System.InvalidOperationException("Invalid Vertex");
        }

        public void InsertVertex(string name)
        {
            vertexList[n++] = new Vertex(name);
        }
        
        private bool IsAdjacent(int u, int v)
        {
            return adj[u, v] != 0;
        }

        private int TempVertex()
        {
            int min = INFINITY;
            int x = NIL;
            for (int v = 0; v < n; v++)
            {
                if (vertexList[v].status == TEMPORARY && vertexList[v].pathLength < min)
                {
                    min = vertexList[v].pathLength;
                    x = v;
                }
            }
            return x;
        }

        public void InsertEdge(string v1, string v2, int v3)
        {
            int i = GetIndex(v1);
            int j = GetIndex(v2);
            adj[i, j] = v3;
            adj[j, i] = v3;
        }

        public void DeleteEdge(string v1, string v2)
        {
            int i = GetIndex(v1);
            int j = GetIndex(v2);
            adj[i, j] = INFINITY;
            adj[j, i] = INFINITY;
        }

        public void ChangeEdge(string v1, string v2, int v3)
        {
            int i = GetIndex(v1);
            int j = GetIndex(v2);
            adj[i, j] = v3;
            adj[j, i] = v3;
        }

        internal static class Program
        {
            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Menu(new List<Edge>()));
            }
        }
    }
}