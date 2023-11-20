using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhieuThue
{
    public partial class Form1 : Form
    {
        List<PhieuThue> dsPT = new List<PhieuThue>();
       
        public Form1()
        {
            InitializeComponent();
            loadData();
            display();
        }

        public void display()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsPT;
            dgvPT.DataSource = bs;
        }
        private KieuLoaiPhong getLoaiPhong()
        {
            if (rbtnA.Checked == true)
                return KieuLoaiPhong.A;
            else if (rbtnB.Checked == true)
                return KieuLoaiPhong.B;
            else if (rbtnC.Checked == true)
                return KieuLoaiPhong.C;
            else
                return KieuLoaiPhong.D;
        }
        private void setLoaiPhong(KieuLoaiPhong loaiPhong)
        {
            switch (loaiPhong)
            {
                case KieuLoaiPhong.A:
                    rbtnA.Checked = true;
                    break;
                case KieuLoaiPhong.B:
                    rbtnB.Checked = true; break;
                case KieuLoaiPhong.C:
                    rbtnC.Checked = true; break;
                case KieuLoaiPhong.D:
                    rbtnD.Checked = true; break;
            }
        }

        private PhieuThue tim(int mapt)
        {
            foreach (PhieuThue pt in dsPT)
            {
                if (pt.MaPT == mapt)
                    return pt;
            }return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int mapt = int.Parse(txtMaPT.Text);
            DateTime ngaybd = dtNgayBD.Value;
            DateTime ngaykt = dtNgayKT.Value;
            string tenkh = txtTenKH.Text;

            PhieuThue temp = new PhieuThue(mapt, ngaybd, ngaykt, tenkh, getLoaiPhong());

            dsPT.Add(temp);

            display();
        }

        public void loadData()
        {
            PhieuThue pt1 = new PhieuThue(
                010,
                new DateTime(2023, 09, 01),
                DateTime.Today,
                "Tran Van A",
                KieuLoaiPhong.A);
            PhieuThue pt2 = new PhieuThue(
                021,
                new DateTime(2023, 08, 11),
                DateTime.Today,
                "Huỳnh Văn B",
                KieuLoaiPhong.C);
            PhieuThue pt3 = new PhieuThue(
                033,
                new DateTime(2023, 01, 11),
                DateTime.Today,
                "Anh ba sỉn",
                KieuLoaiPhong.D);
            PhieuThue pt4 = new PhieuThue(
                111,
                new DateTime(2023, 03, 01),
                DateTime.Today,
                "Ăn Cam Mỹ",
                KieuLoaiPhong.D);

            dsPT.Add(pt1);
            dsPT.Add(pt2);
            dsPT.Add(pt3);
            dsPT.Add(pt4);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult a = MessageBox.Show(
                "Bạn thật sự muốn thoát?",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (a == DialogResult.Yes)
            {
                MessageBox.Show("Cảm ơn đã sử dụng chương trình.");
            }
            else if (a == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        int index;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult a = MessageBox.Show(
                    "Bạn có chắc muốn xóa?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    );
                if (a == DialogResult.Yes)
                {
                    dsPT.RemoveAt(index);
                    display();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgvPT_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPT.Text = dgvPT.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtNgayBD.Value = Convert.ToDateTime(dgvPT.Rows[e.RowIndex].Cells[1].Value.ToString());
            dtNgayKT.Value = Convert.ToDateTime(dgvPT.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtTenKH.Text = dgvPT.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvPT.Rows[e.RowIndex].Cells[4].Value.ToString() == "A")
                rbtnA.Checked = true;
            else if (dgvPT.Rows[e.RowIndex].Cells[4].Value.ToString() == "B")
                rbtnB.Checked = true;
            else if (dgvPT.Rows[e.RowIndex].Cells[4].Value.ToString() == "C")
                rbtnC.Checked = true;
            else
                rbtnD.Checked = true;
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPT.SelectedRows.Count == 0)
                return;
            index = dgvPT.SelectedRows[0].Index;
            PhieuThue pt = dsPT[index];
            pt.NgayBD = dtNgayBD.Value;
            pt.NgayKT = dtNgayKT.Value;
            pt.TenKH = txtTenKH.Text;
            pt.MaPT = int.Parse(txtMaPT.Text);
            pt.LoaiPhong = getLoaiPhong();
            display();

        }

        private bool luuFile(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                BinaryFormatter bs = new BinaryFormatter();
                bs.Serialize(fs, dsPT);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            if (dlg.FileName != "")
            {
                if (luuFile(dlg.FileName) == true)
                    MessageBox.Show("Lưu file thành công");
                else
                    MessageBox.Show("Lưu file thất bại");
            }

        }

        private bool moFile(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                BinaryFormatter bs = new BinaryFormatter();
                dsPT = (List<PhieuThue>)bs.Deserialize(fs);
                fs.Close();
                return true;
            }
            catch (Exception) { return false; }
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.ShowDialog();
            if (a.FileName != "")
            {
                if (moFile(a.FileName) == true)
                {
                    display();
                    MessageBox.Show("Mở file thành công");
                }
                else
                    MessageBox.Show("Mở file thất bại.");
            }
        }

      
    }
}
