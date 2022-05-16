using QLGDB.Common;
using QLGDB.Model;
using QLGDB.Service;
using System;
using System.Windows.Forms;

namespace QLGDB.Controller
{
    public partial class fr_Chondoi : Form
    {
        private readonly DoiBongService _service = new DoiBongService();
        private readonly GiaiDauService _serviceGD = new GiaiDauService();
        private readonly message message = new message();

        public static string madoi = "0";
        public static string tendoi = "";
        public fr_Chondoi()
        {
            InitializeComponent();
            FilltextMuaGiai();
            LoadData(null, null, null);
        }
        protected void LoadData(int? _IdGiaiDau, string _TenDoi, string _Tenkhoa)
        {
            try
            {
                msds.DataSource = _service.Query(new DoiBongQueryModel()
                {
                    IdGiaiDau = _IdGiaiDau,
                    TenDoi = _TenDoi,
                    Tenkhoa = _Tenkhoa,
                });
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Tên Đội";
                msds.Columns[2].HeaderText = "Tên Khoa";
                msds.Columns[3].HeaderText = "Tên Giải";
            }
            catch (Exception)
            {
                message.Message();
            }
        }
        protected void FilltextMuaGiai()
        {
            try
            {
                cbGiai.DataSource = _serviceGD.Query(new GiaiDauQueryModel { TenGiaiDau = null, ThoiGianBatDau = null, ThoiGianKetThuc = null });
                cbGiai.DisplayMember = "TenGiaiDau";
                cbGiai.ValueMember = "Id";
            }
            catch (Exception)
            {
                message.Message();
            }

        }
        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_madoi.Text) && !string.IsNullOrEmpty(txt_tendoi.Text))
                {
                    madoi = txt_madoi.Text.Trim();
                    tendoi = txt_tendoi.Text.Trim();
                    this.Close();
                    Dispose();
                }
                else
                {
                    message.MessageFalse();
                }
            }
            catch (Exception)
            {
                message.Message();
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
            Dispose();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_madoi.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_tendoi.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString();
            txt_tenkhoa.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            cbGiai.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
        }

        private void cbGiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGiai.SelectedIndex > 0)
            {
                LoadData((int)cbGiai.SelectedValue, null, null);
            }
        }
    }
}
