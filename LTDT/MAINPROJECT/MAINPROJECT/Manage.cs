using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace MAINPROJECT
{
    public partial class Manage : Form
    {
        public List<Edge> Edges = new List<Edge>();
        public Manage(List<Edge> Edgessend)
        {
            InitializeComponent();
            //Lay canh tu Menu.
            Edges = Edgessend;
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            cb_Start.Items.Add("Brunei");
            cb_Start.Items.Add("Cambodia");
            cb_Start.Items.Add("Indonesia");
            cb_Start.Items.Add("Laos");
            cb_Start.Items.Add("Malaysia");
            cb_Start.Items.Add("Myanmar");
            cb_Start.Items.Add("Philippines");
            cb_Start.Items.Add("Singapore");
            cb_Start.Items.Add("Thailand");
            cb_Start.Items.Add("Timor-Leste");
            cb_Start.Items.Add("Vietnam");

            cb_End.Items.Add("Brunei");
            cb_End.Items.Add("Cambodia");
            cb_End.Items.Add("Indonesia");
            cb_End.Items.Add("Laos");
            cb_End.Items.Add("Malaysia");
            cb_End.Items.Add("Myanmar");
            cb_End.Items.Add("Philippines");
            cb_End.Items.Add("Singapore");
            cb_End.Items.Add("Thailand");
            cb_End.Items.Add("Timor-Leste");
            cb_End.Items.Add("Vietnam");

            LoadListView();
        }
        // hiển thị list danh sách departure - destination
        void LoadListView()
        {
            lsvShow.Items.Clear();
            lsvShow.View = View.Details;
            for (int i = 0; i < Edges.Count; i++)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = Edges[i].getDeparture();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Edges[i].getDestination() });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Edges[i].getKilometer().ToString() });
                lsvShow.Items.Add(item1);
            }
        }

        private void cb_Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Start.SelectedIndex == cb_End.SelectedIndex)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
            }
        }

        private void cb_End_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Start.SelectedIndex == cb_End.SelectedIndex)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
            }
        }
        // nhập khoảng cách chỉ dùng số
        private void cb_Distance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_Start.SelectedIndex == -1 || cb_End.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đúng trình tự!\nĐiểm đi và điểm đến trước!", "Thông báo");
                e.Handled = true;
                return;
            }
            if (cb_Start.SelectedIndex == cb_End.SelectedIndex && cb_Start.SelectedIndex != -1)
            {
                MessageBox.Show("Có vẻ nhầm lẫn!\nĐiểm đi và điểm đến giống nhau !", "Thông báo");
                e.Handled = true;
                return;
            }
            if ((cb_Start.SelectedIndex != -1 || cb_End.SelectedIndex != -1) && cb_Start.SelectedIndex != cb_End.SelectedIndex)
            {
                cb_Distance.KeyPress += cb_Distance_KeyPress;
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46) // 8 là mã ASCII cho phím Backspace, 46 cho dấu "."
                {
                    e.Handled = true; // Ngừng sự kiện KeyPress nếu không phải số
                }
            }
        }
        // MỞ ĐƯỜNG BAY MỚI
        private void bt_AddNew_Click(object sender, EventArgs e)
        {
            if (cb_Start.SelectedIndex == -1 || cb_End.SelectedIndex == -1 || cb_Distance.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nTrước khi thêm mới đường bay", "Thông báo");
                return;
            }

            string selectedDeparture = cb_Start.SelectedItem.ToString();
            string selectedDestination = cb_End.SelectedItem.ToString();
            string distanceInput = cb_Distance.Text;

            bool isDuplicate = false;
            for (int i = 0; i < Edges.Count; i++)
            {
                if ((Edges[i].getDeparture() == selectedDeparture && Edges[i].getDestination() == selectedDestination) || (Edges[i].getDeparture() == selectedDestination && Edges[i].getDestination() == selectedDeparture))
                {
                    isDuplicate = true;
                    MessageBox.Show("Đường bay đã tồn tại!\nBạn chỉ có thể 'CẬP NHẬT ĐƯỜNG BAY'", "Thông báo");
                    break;
                }
            }
            if (isDuplicate)
                return;

            if ((Double.TryParse(distanceInput, out double kilometer) && kilometer > 0))
            {
                int distance = (int)Math.Ceiling(kilometer);
                Edges.Add(new Edge(selectedDeparture, selectedDestination, distance));
                MessageBox.Show("Thêm vào thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi");
                return;
            }
            LoadListView();
        }
        // HÀM CẬP NHẬT CHUYẾN BAY
        private void bt_Update_Click(object sender, EventArgs e)
        {
            if (cb_Start.SelectedIndex == -1 || cb_End.SelectedIndex == -1 || cb_Distance.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nTrước khi cập nhật đường bay", "Thông báo");
                return;
            }

            string distanceInput = cb_Distance.Text;
            if ((Double.TryParse(distanceInput, out double kilometer) && kilometer > 0))
            {
                bool isFound = false;
                string selectedDeparture = cb_Start.SelectedItem.ToString();
                string selectedDestination = cb_End.SelectedItem.ToString();

                for (int i = 0; i < Edges.Count; i++)
                {
                    if ((Edges[i].getDeparture() == selectedDeparture && Edges[i].getDestination() == selectedDestination) || (Edges[i].getDeparture() == selectedDestination && Edges[i].getDestination() == selectedDeparture))
                    {
                        int distance = (int)Math.Ceiling(kilometer);
                        Edges[i].setKilometers(distance);
                        isFound = true;
                        break;
                    }
                }
                LoadListView();
                if (isFound)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Đường bay không tồn tại!", "Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ!", "Lỗi");
                return;
            }
        }
        // HÀM XÓA ĐƯỜNG BAY
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (cb_Start.SelectedIndex == -1 || cb_End.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!\nTrước khi xóa đường bay", "Thông báo");
                return;
            }

            string selectedDeparture = cb_Start.SelectedItem.ToString();
            string selectedDestination = cb_End.SelectedItem.ToString();
            bool isFound = false;

            for (int i = 0; i < Edges.Count; i++)
            {
                if ((Edges[i].getDeparture() == selectedDeparture && Edges[i].getDestination() == selectedDestination) || (Edges[i].getDeparture() == selectedDestination && Edges[i].getDestination() == selectedDeparture))
                {
                    Edges.Remove(Edges[i]);
                    isFound = true;
                    break;
                }
            }
            LoadListView();
            if (isFound) {
                MessageBox.Show("Xóa thành công!", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Đường bay không tồn tại!", "Thông báo");
                return;
            }
        }
    }
}
