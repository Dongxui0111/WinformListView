using System;
using System.Windows.Forms;

namespace ListViewBT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtMa.Text;
                item.SubItems.Add(txtTen.Text);
                item.SubItems.Add(txtSluong.Text);
                livHang.Items.Add(item);
            }
            else MessageBox.Show("Lỗi nhập dữ liệu", "Thông báo");
        }
        //Kiem tra
        private bool check()
        {
            if (txtSluong.Text.Trim() == "" || txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "")
            { return false; }
            foreach (ListViewItem x in livHang.Items)
            {
                if (String.Compare(x.Text, txtMa.Text, true) == 0)
                    return false;
            }
            return true;
        }

        private void livHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (livHang.SelectedItems.Count > 0)
            {
                int i = livHang.SelectedItems[0].Index;
                if (i >= 0)
                {
                    txtMa.Text = livHang.Items[i].Text;
                    txtTen.Text = livHang.Items[i].SubItems[1].Text;
                    txtSluong.Text = livHang.Items[i].SubItems[2].Text;
                }
            }
        }

        //Sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (livHang.SelectedItems.Count > 0)
            {
                int i = livHang.SelectedItems[0].Index;
                if (MessageBox.Show("Bạn muốn sửa không ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (i >= 0)
                    {
                        //livHang.Items[i].Text = txtMa.Text;
                        livHang.Items[i].SubItems[1].Text = txtTen.Text;
                        livHang.Items[i].SubItems[2].Text = txtSluong.Text;
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (livHang.SelectedItems.Count > 0)
            {
                int i = livHang.SelectedItems[0].Index;
                if (MessageBox.Show("Bạn muốn xóa không ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (i >= 0)
                    {
                        livHang.Items.RemoveAt(i);
                    }
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtSluong.Clear();
            txtTen.Clear();
        }
    }
}
