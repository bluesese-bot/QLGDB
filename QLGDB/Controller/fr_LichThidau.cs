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
    public partial class fr_LichThidau : Form
    {
        private readonly LichThiDauService _service = new LichThiDauService();
        private readonly DoiBongService _serviceB = new DoiBongService();
        private readonly GiaiDauService _serviceGD = new GiaiDauService();
        private readonly message message = new message();
        private bool _isAdd = false;
        private bool _isEdit = false;
        public fr_LichThidau()
        {
            InitializeComponent();
            LoadData(null, null, null, null);
            FilltextDoi(txt_doi1);
            FilltextDoi(txt_doi2);
            FilltextMuaGiai();
            LockText();
            SetNull();
        }
        protected void FilltextDoi(ComboBox box)
        {
            try
            {
                box.DataSource = _serviceB.Query(new DoiBongQueryModel()
                {
                    IdGiaiDau = null,
                    TenDoi = null,
                    Tenkhoa = null,
                });
                box.DisplayMember = "TenDoi";
                box.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void FilltextMuaGiai()
        {
            try
            {
                txt_muagiai.DataSource = _serviceGD.Query(new GiaiDauQueryModel { TenGiaiDau = null, ThoiGianBatDau = null, ThoiGianKetThuc = null });
                txt_muagiai.DisplayMember = "TenGiaiDau";
                txt_muagiai.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        protected void LoadData(int? _IdDoi, int? _IdGiai, int? _SBTDOI, DateTime? _ThoiThiDau)
        {
            try
            {
                msds.DataSource = _service.Query(new LichThiDauQueryModel()
                {
                    IdDoi = _IdDoi,
                    IdGiai = _IdGiai,
                    SBTDOI = _SBTDOI,
                    ThoiThiDau = _ThoiThiDau

                });
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Tên Giải";
                msds.Columns[2].HeaderText = "Số Trận";
                msds.Columns[3].HeaderText = "Tên Đội 1";
                msds.Columns[4].HeaderText = "Tên Đội 2";
                msds.Columns[5].HeaderText = "Thời Gian Thi Đấu";
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

            txt_doi1.SelectedIndex = -1;
            txt_doi2.SelectedIndex = -1;
            txt_muagiai.SelectedIndex = -1;
            txt_matrandau.Text = null;
            tm_Thoigian.Value = DateTime.Now;
            txt_sotran.Text = null;
        }
        protected void LockText()
        {
            txt_muagiai.Enabled = false;
            txt_doi1.Enabled = false;
            txt_doi2.Enabled = false;
            tm_Thoigian.Enabled = false;
            txt_sotran.Enabled = false;

            button_them.Enabled = true;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_ok.Enabled = false;
            button_huy.Enabled = false;
        }
        protected void UnlockText()
        {
            txt_muagiai.Enabled = true;
            txt_doi1.Enabled = true;
            txt_doi2.Enabled = true;
            tm_Thoigian.Enabled = true;
            txt_sotran.Enabled = true;

            button_them.Enabled = false;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            button_ok.Enabled = true;
            button_huy.Enabled = true;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            _isAdd = true;
            UnlockText();
            SetNull();
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

        private void button_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _service.Delete(Convert.ToInt32(txt_matrandau.Text));
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
                LoadData(null, null, null, null);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_muagiai.SelectedIndex != -1 && !string.IsNullOrEmpty(txt_doi1.Text) && !string.IsNullOrEmpty(txt_doi2.Text) && tm_Thoigian.Text != "")
                {
                    if (_isAdd)
                    {
                        var res = _service.Add(new LichThiDauAddModel()
                        {
                            IdGiai = Convert.ToInt32(txt_muagiai.SelectedValue),
                            IdDoi1 = Convert.ToInt32(txt_doi1.SelectedValue),
                            IdDoi2 = Convert.ToInt32(txt_doi2.SelectedValue),
                            ThoiThiDau = tm_Thoigian.Value,
                            TranDau = Convert.ToInt32(txt_sotran.Text),
                            SBTDOI1 = -1,
                            SBTDOI2 = -1
                        });
                        if (res == false)
                        {
                            message.MessageFalse();
                        }
                    }
                    if (_isEdit)
                    {
                        var res = _service.Edit(new LichThiDauUpdateModel()
                        {
                            Id = Convert.ToInt32(txt_matrandau.Text),
                            IdGiai = Convert.ToInt32(txt_muagiai.SelectedValue),
                            IdDoi1 = Convert.ToInt32(txt_doi1.SelectedValue),
                            IdDoi2 = Convert.ToInt32(txt_doi2.SelectedValue),
                            ThoiThiDau = tm_Thoigian.Value,
                            TranDau = Convert.ToInt32(txt_sotran.Text),
                            SBTDOI1 = -1,
                            SBTDOI2 = -1
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
                LoadData(null, null, null,null);
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
            txt_matrandau.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString() == null ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_muagiai.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString() == null ? null: msds.Rows[dong].Cells[1].Value.ToString();
            txt_sotran.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString() == null ? null : msds.Rows[dong].Cells[2].Value.ToString();
            txt_doi1.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString() == null ? null : msds.Rows[dong].Cells[3].Value.ToString();
            txt_doi2.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[4].Value.ToString() == null ? null : msds.Rows[dong].Cells[4].Value.ToString();
            tm_Thoigian.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[5].Value.ToString() == null ? null : msds.Rows[dong].Cells[5].Value.ToString();
        }
    }
}
