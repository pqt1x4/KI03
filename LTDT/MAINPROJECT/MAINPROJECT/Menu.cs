using System.Windows.Forms;

namespace MAINPROJECT
{
    public partial class Menu:Form
    {
        public List<Edge> Edges = new List<Edge>();

        public Menu(List<Edge> EdgesSend)
        {
            InitializeComponent();
            Edges=EdgesSend;

            tb_title.Text="ĐỒ ÁN KẾT THÚC MÔN HỌC LÍ THUYẾT ĐỒ THỊ & ỨNG DỤNG";
            tb_title2.Text="ĐỀ TÀI: \r\nMINH HỌA TRỰC QUAN THUẬT TOÁN DIJKSTRA VÀ \r\nỨNG DỤNG TÌM ĐƯỜNG BAY NGẮN NHẤT GIỮA 11 VÙNG THỦ ĐÔ ĐÔNG NAM Á.";

            //KHOI TAO MAC DINH DANH SACH CAC CANH (DUONG BAY)
            Edges.Add(new Edge("Vietnam","Myanmar",1050));
            Edges.Add(new Edge("Vietnam","Indonesia",4270));
            Edges.Add(new Edge("Vietnam","Malaysia",2240));
            Edges.Add(new Edge("Vietnam","Philippines",2410));
            Edges.Add(new Edge("Vietnam","Singapore",3050));
            Edges.Add(new Edge("Vietnam","Thailand",1100));
            Edges.Add(new Edge("Vietnam","Brunei",3280));
            Edges.Add(new Edge("Vietnam","Timor-Leste",4010));
            Edges.Add(new Edge("Indonesia","Timor-Leste",2150));
            Edges.Add(new Edge("Laos","Myanmar",1080));
            Edges.Add(new Edge("Myanmar","Malaysia",2390));
            Edges.Add(new Edge("Indonesia","Malaysia",1260));
            Edges.Add(new Edge("Malaysia","Thailand",1450));
            Edges.Add(new Edge("Malaysia","Cambodia",1270));
            Edges.Add(new Edge("Singapore","Cambodia",1300));
            Edges.Add(new Edge("Singapore","Philippines",3050));
            Edges.Add(new Edge("Indonesia","Philippines",3020));
            Edges.Add(new Edge("Laos","Philippines",2600));
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild=childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle=FormBorderStyle.None;
            childForm.Dock=DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag=childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bt_Show_Click(object sender,EventArgs e)
        {
            Show Child = new Show(Edges);
            OpenChildForm(Child);
            lb_Title.Text="HIỂN THỊ ĐƯỜNG BAY";
        }

        private void bt_Manage_Click(object sender,EventArgs e)
        {

            Manage Child = new Manage(Edges);
            OpenChildForm(Child);
            lb_Title.Text="QUẢN LÍ ĐƯỜNG BAY";
        }

        private void pictureBox1_Click(object sender,EventArgs e)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            lb_Title.Text="GIỚI THIỆU HỆ THỐNG TRA CỨU ĐƯỜNG BAY NGẮN NHẤT BẰNG THUẬT TOÁN DIJKSTRA";
        }
    }
}
