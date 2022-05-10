using QLGDB.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLGDB.Service;
using QLGDB.Model;

namespace QLGDB.Controller
{
    public partial class fr_Themgiaidau : Form
    {
        private readonly GiaiDauService _service = new GiaiDauService();
        private readonly message message = new message();
        private bool _isAdd = false;
        private bool _isEdit = false;
        public fr_Themgiaidau()
        {
            InitializeComponent();
            LockText();
            LoadData(null, null, null);
        }
        protected void LoadData(string _TenGiaiDau, DateTime? _ThoiGianBatDau, DateTime? _ThoiGianKetThuc)
        {
            try
            {
                msds.DataSource = _service.Query(new GiaiDauQueryModel()
                {
                    TenGiaiDau = _TenGiaiDau,
                    ThoiGianBatDau = _ThoiGianBatDau,
                    ThoiGianKetThuc = _ThoiGianKetThuc,
                });
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Tên Mùa Giải";
                msds.Columns[2].HeaderText = "Thời Gian Bắt Đầu";
                msds.Columns[3].HeaderText = "Thời Gian Kết Thúc";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void LockText()
        {
            txt_tenmua.Enabled = false;
            time_thoigianbatdau.Enabled = false;
            time_thoigianketthuc.Enabled = false;

            button_them.Enabled = true;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_ok.Enabled = false;
            button_huy.Enabled = false;
        }
        protected void UnlockText()
        {
            txt_tenmua.Enabled = true;
            time_thoigianbatdau.Enabled = true;
            time_thoigianketthuc.Enabled = true;

            button_them.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_ok.Enabled = true;
            button_huy.Enabled = true;
        }
        protected void SetNull()
        {
            _isAdd = false;
            _isEdit = false;

            txt_tenmua.Text = null;
            txt_mamua.Text = null;
            time_thoigianbatdau.Value = DateTime.Today;
            time_thoigianketthuc.Value = DateTime.Today;
        }
        private void button_them_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            UnlockText();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_mamua.Text)) 
            {
                _isEdit = true;
                UnlockText();
            }
            else
            {
                message.MessageFalse();
            }
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_mamua.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_tenmua.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString();
            time_thoigianbatdau.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            time_thoigianketthuc.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _service.Delete(Convert.ToInt32(txt_mamua.Text));
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
                SetNull();
                LoadData(null, null, null);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenmua.Text != "" && time_thoigianbatdau.Text != "" && time_thoigianketthuc.Text != "")
                {
                    if(_isAdd)
                    {
                        var res = _service.Add(new GiaiDauAddModel()
                        {
                            TenGiaiDau = txt_tenmua.Text,
                            ThoiGianBatDau = time_thoigianbatdau.Value,
                            ThoiGianKetThuc = time_thoigianketthuc.Value,
                        });
                        if (res == false)
                        {
                            message.MessageFalse();
                        }
                    }
                    if (_isEdit)
                    {
                        var res = _service.Edit(new GiaiDauUpdateModel()
                        {
                            Id = Convert.ToInt32(txt_mamua.Text),
                            TenGiaiDau = txt_tenmua.Text,
                            ThoiGianBatDau = time_thoigianbatdau.Value,
                            ThoiGianKetThuc = time_thoigianketthuc.Value
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
                SetNull();
                LockText();
                LoadData(null,null,null);
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            LockText();
            SetNull();
        }
    }
}
