using QLGDB.Model;
using QLGDB.Service;
using System;
using System.Windows.Forms;
using QLGDB.Common;

namespace QLGDB.Controller
{
    public partial class fr_Base : Form
    {
        private readonly CauThuService _service = new CauThuService();
        private readonly message message = new message();
        public fr_Base()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            try
            {
                msds.DataSource = _service.Query(new CauThuQueryModel()
                {
                    GhiChu = null,
                    HoTen = null,
                    Msv = null,
                    TenLop = null,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txtID.Text = msds.Rows[dong].Cells[0].Value.ToString();
            txtMSV.Text = msds.Rows[dong].Cells[1].Value.ToString();
            txtHoten.Text = msds.Rows[dong].Cells[2].Value.ToString();
            txtTenLop.Text = msds.Rows[dong].Cells[3].Value.ToString();
            txtGhiChu.Text = msds.Rows[dong].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMSV.Text != "" && txtHoten.Text != "" && txtTenLop.Text != "" && txtGhiChu.Text != "")
                {
                    var res = _service.Add(new CauThuAddModel()
                    {
                        GhiChu = txtGhiChu.Text,
                        HoTen = txtHoten.Text,
                        TenLop = txtTenLop.Text,
                        Msv = txtMSV.Text
                    });
                    if (res == null)
                    {
                        message.MessageFalse();
                    }
                }
                else
                {
                    message.MessageFalse();
                }
            }
            catch (Exception ex)
            {
                message.Message();
            }
            finally
            {
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _service.Edit(new CauThuUpdateModel()
                {
                    Id = Convert.ToInt32(txtID.Text),
                    GhiChu = txtGhiChu.Text,
                    HoTen = txtHoten.Text,
                    TenLop = txtTenLop.Text,
                    Msv = txtMSV.Text
                });
                if( res == false)
                {
                    if (res == false)
                    {
                        message.MessageFalse();
                    }
                }
            }
            catch (Exception ex)
            {
                message.Message();
            }
            finally
            {
                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var res = _service.Delete(Convert.ToInt32(txtID.Text));
                if (res == false)
                {
                    if (res == false)
                    {
                        message.MessageFalse();
                    }
                }
            }
            catch (Exception ex)
            {
                message.Message();
            }
            finally
            {
                LoadData();
            }
        }

        private void fr_Base_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _service.GetListCauThuByDoiBongId(1);
        }
    }
}
