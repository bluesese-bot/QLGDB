using QLGDB.Common;
using QLGDB.Model;
using QLGDB.Service;
using System;
using System.Windows.Forms;

namespace QLGDB.Controller
{
    public partial class fr_Dangkydoi : Form
    {
        private readonly DoiBongService _service = new DoiBongService();
        private readonly GiaiDauService _serviceGD = new GiaiDauService();
        private readonly DoiBongCauThuService _serviceDBCT = new DoiBongCauThuService();
        private readonly LichThiDauService _thiDauService = new LichThiDauService();
        private readonly message message = new message();
        private bool _isAdd = false;
        private bool _isEdit = false;

        public fr_Dangkydoi()
        {
            InitializeComponent();
            LoadData(null,null,null);
            FilltextMuaGiai();
            LockText();
            cbGiai.SelectedIndex = -1;
        }
        protected void FilltextMuaGiai()
        {
            try
            {
                cbGiai.DataSource = _serviceGD.Query(new GiaiDauQueryModel { TenGiaiDau = null, ThoiGianBatDau = null, ThoiGianKetThuc = null});
                cbGiai.DisplayMember = "TenGiaiDau";
                cbGiai.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void SetNull()
        {
            _isAdd = false;
            _isEdit = false;

            txt_madoi.Text = null;
            txt_tendoi.Text = null;
            txt_tenkhoa.Text = null;
            cbGiai.SelectedIndex = -1;
        }
        protected void LockText()
        {
            txt_tendoi.Enabled = false;
            txt_tenkhoa.Enabled = false;
            cbGiai.Enabled = false;

            button_them.Enabled = true;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_ok.Enabled = false;
            button_huy.Enabled = false;
        }
        protected void UnlockText()
        {
            txt_tendoi.Enabled = true;
            txt_tenkhoa.Enabled = true;
            cbGiai.Enabled = true;

            button_them.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_ok.Enabled = true;
            button_huy.Enabled = true;
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_madoi.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_tendoi.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString();
            txt_tenkhoa.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            cbGiai.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            UnlockText();
            SetNull();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_tendoi.Text) && !string.IsNullOrEmpty(txt_tenkhoa.Text) && cbGiai.SelectedIndex != -1)
                {
                    if (_isAdd)
                    {
                        var res = _service.Add(new DoiBongAddModel()
                        {
                            TenDoi = txt_tendoi.Text,
                            Tenkhoa = txt_tenkhoa.Text,
                            IdGiaiDau = Convert.ToInt32(cbGiai.SelectedValue),

                        });
                        if (res == false)
                        {
                            message.MessageFalse();
                        }
                    }
                    if (_isEdit)
                    {
                        var res = _service.Edit(new DoiBongUpdateModel()
                        {
                            Id = Convert.ToInt32(txt_madoi.Text),
                            TenDoi = txt_tendoi.Text,
                            Tenkhoa = txt_tenkhoa.Text,
                            IdGiaiDau = Convert.ToInt32(cbGiai.SelectedValue)
                        });
                        if (res == false)
                        {
                            message.MessageFalse();
                        }
                    }
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
            finally
            {
                LockText();
                SetNull();
                LoadData(null, null, null);
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            LockText();
            SetNull();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var resthiDau = _thiDauService.DeletebyIDdoi(Convert.ToInt32(txt_madoi.Text));
                var resDBCT = _serviceDBCT.Delete(Convert.ToInt32(txt_madoi.Text));
                var res = _service.Delete(Convert.ToInt32(txt_madoi.Text));
                if (res == false)
                {
                    message.MessageFalse();
                }
            }
            catch (Exception)
            {
                message.Message();
            }
            finally
            {
                LockText();
                LoadData(null, null, null);
                }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_madoi.Text))
            {
                _isEdit = true;
                UnlockText();
            }
            else
            {
                message.MessageFalse();
            }
        }
    }
}
