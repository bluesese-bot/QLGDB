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
    public partial class fr_TySo : Form
    {
        private readonly LichThiDauService _service = new LichThiDauService();
        private readonly message message = new message();
        private bool _isEdit = false;
        public fr_TySo()
        {
            InitializeComponent();
            LockText();
            LoadData(null, null, null, null);
        }

        protected void LoadData(int? _IdDoi, int? _IdGiai, int? _SBTDOI, DateTime? _ThoiThiDau)
        {
            try
            {
                msds.DataSource = _service.GetList(new LichThiDauQueryModel()
                {
                    IdDoi = _IdDoi,
                    IdGiai = _IdGiai,
                    SBTDOI = _SBTDOI,
                    ThoiThiDau = _ThoiThiDau

                });
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Tên Giải";
                msds.Columns[2].HeaderText = "Tên Đội 1";
                msds.Columns[3].HeaderText = "Tên Đội 2";
                msds.Columns[4].HeaderText = "Thời Gian Thi Đấu";
                msds.Columns[5].HeaderText = "Số Bàn Thắng Đội 1";
                msds.Columns[6].HeaderText = "Số Bàn Thắng Đội 2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void SetNull()
        {
            _isEdit = false;

            txt_doi1.Text = null;
            txt_doi2.Text = null;
            txt_banthangdoi1.Text = null;
            txt_banthangdoi2.Text = null;
            txt_matrandau.Text = null;
        }
        protected void LockText()
        {
            txt_matrandau.Enabled = false;
            txt_doi1.Enabled = false;
            txt_doi2.Enabled = false;
            txt_banthangdoi1.Enabled = false;
            txt_banthangdoi2.Enabled = false;

            button_them.Enabled = true;
            button_sua.Enabled = true;
            button_ok.Enabled = false;
            button_huy.Enabled = false;
        }
        protected void UnlockText()
        {
            txt_matrandau.Enabled = true;
            txt_doi1.Enabled = true;
            txt_doi2.Enabled = true;
            txt_banthangdoi1.Enabled = true;
            txt_banthangdoi2.Enabled = true;

            button_them.Enabled = false;
            button_sua.Enabled = false;
            button_ok.Enabled = true;
            button_huy.Enabled = true;
        }
        private void txt_banthangdoi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_banthangdoi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            fr_ChonTranDau ChonTranDau = new fr_ChonTranDau();
            ChonTranDau.ShowDialog();
            txt_doi1.Text = fr_ChonTranDau.doi1;
            txt_doi2.Text = fr_ChonTranDau.doi2;
            txt_matrandau.Text = fr_ChonTranDau.matrandau;
            _isEdit = fr_ChonTranDau.isStatus == true ? true : false;
            LoadData(null, null, null, null);
            UnlockText();
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_matrandau.Text))
            {
                _isEdit = true;
                UnlockText();
            }
            else
            {
                message.MessageFalse();
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_matrandau.Text) && !string.IsNullOrEmpty(txt_doi1.Text) && !string.IsNullOrEmpty(txt_doi2.Text))
                {
                    if (_isEdit)
                    {
                        var res = _service.EditTySo(new LichThiDauUpdateModel()
                        {
                            Id = Convert.ToInt32(txt_matrandau.Text),
                            SBTDOI1 = Convert.ToInt32(txt_banthangdoi1.Text),
                            SBTDOI2 = Convert.ToInt32(txt_banthangdoi2.Text)
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
                LoadData(null, null, null, null);
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            SetNull();
            LockText();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_matrandau.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_doi1.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            txt_doi2.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
            txt_banthangdoi1.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[5].Value.ToString();
            txt_banthangdoi2.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[6].Value.ToString();

        }
    }
}
