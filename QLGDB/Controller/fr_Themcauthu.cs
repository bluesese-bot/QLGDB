using QLGDB.Common;
using QLGDB.Model;
using QLGDB.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGDB.Controller
{
    public partial class fr_Themcauthu : Form
    {
        private readonly CauThuService _service = new CauThuService();
        private readonly DoiBongCauThuService _serviceDB = new DoiBongCauThuService();
        private readonly message message = new message();
        private bool _isAdd = false;
        private bool _isEdit = false;
        public fr_Themcauthu()
        {
            InitializeComponent();
            txt_madoi.Text = null;
            LockText();
        }
        protected void LoadData(int? id)
        {
            try
            {
                msds.DataSource = _service.GetListCauThuByDoiBongId(id);
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Mã Sinh Viên";
                msds.Columns[2].HeaderText = "Họ Tên";
                msds.Columns[3].HeaderText = "Tên Lớp";
                msds.Columns[4].HeaderText = "Ghi Chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void LockText()
        {
            txtMSV.Enabled = false;
            txt_hoten.Enabled = false;
            txt_lop.Enabled = false;
            txt_ghichu.Enabled = false;

            button_them.Enabled = true;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_ok.Enabled = false;
            button_huy.Enabled = false;
        }
        protected void UnlockText()
        {
            txtMSV.Enabled = true;
            txt_hoten.Enabled = true;
            txt_lop.Enabled = true;
            txt_ghichu.Enabled = true;

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

            txtMSV.Text = null;
            txt_hoten.Text = null;
            txt_lop.Text = null;
            txt_ghichu.Text = null;
            txt_macauthu.Text = null;
        }
        private void button_chondoi_Click(object sender, EventArgs e)
        {
            fr_Chondoi chondoi = new fr_Chondoi();
            chondoi.ShowDialog();
            txt_tendoi.Text = fr_Chondoi.tendoi;
            txt_madoi.Text = fr_Chondoi.madoi;
            LoadData(Convert.ToInt32(txt_madoi.Text));
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            UnlockText();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_macauthu.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txtMSV.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString();
            txt_hoten.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            txt_lop.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
            txt_ghichu.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[4].Value.ToString();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_macauthu.Text))
            {
                _isEdit = true;
                UnlockText();
            }
            else
            {
                message.MessageFalse();
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var resDB = _serviceDB.Delete(Convert.ToInt32(txt_madoi.Text), Convert.ToInt32(txt_macauthu.Text));
                if (!resDB) message.MessageFalse();
                var res = _service.Delete(Convert.ToInt32(txt_macauthu.Text));
                if (!res) message.MessageFalse();
            }
            catch (Exception)
            {
                message.Message();
            }
            finally
            {
                LockText();
                SetNull();
                if(!string.IsNullOrEmpty(txt_madoi.Text))
                    LoadData(Convert.ToInt32(txt_madoi.Text));
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMSV.Text) && !string.IsNullOrEmpty(txt_hoten.Text) && !string.IsNullOrEmpty(txt_lop.Text) && !string.IsNullOrEmpty(txt_ghichu.Text) && !string.IsNullOrEmpty(txt_madoi.Text))
                {
                    if (_isAdd)
                    {
                        var res = _service.Add(new CauThuAddModel()
                        {
                            Msv = txtMSV.Text,
                            HoTen = txt_hoten.Text,
                            TenLop = txt_lop.Text,
                            GhiChu = txt_ghichu.Text
                        });
                        var resDB = _serviceDB.Add(new DoiBongCauThuAddModel
                        {
                            IdCauThu = res.Id,
                            IdDoi = Convert.ToInt32(txt_madoi.Text)
                        });
                        if (res == null) message.MessageFalse();
                        if(!resDB) message.MessageFalse();
                    }
                    if (_isEdit)
                    {
                        var res = _service.Edit(new CauThuUpdateModel()
                        {
                            Id = Convert.ToInt32(txt_macauthu.Text),
                            Msv = txtMSV.Text,
                            HoTen = txt_hoten.Text,
                            TenLop = txt_lop.Text,
                            GhiChu = txt_ghichu.Text
                        });
                        if (!res) message.MessageFalse();
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
                LoadData(Convert.ToInt32(txt_madoi.Text));
            }
        }
        private void button_huy_Click(object sender, EventArgs e)
        {
            LockText();
            SetNull();
        }
    }
}
