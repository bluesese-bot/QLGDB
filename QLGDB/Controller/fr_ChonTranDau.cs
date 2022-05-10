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
    public partial class fr_ChonTranDau : Form
    {
        private readonly LichThiDauService _service = new LichThiDauService();
        private readonly message message = new message();
        public static string matrandau = string.Empty;
        public static string doi1 = string.Empty;
        public static string doi2 = string.Empty;
        public static bool isStatus = true;
        public fr_ChonTranDau()
        {
            InitializeComponent();
            LoadData(null,-1,null,null);
        }
        protected void LoadData(int? _IdDoi, int? _SBTDOI, int? _IdGiai, DateTime? _ThoiThiDau)
        {
            try
            {
                msds.DataSource = _service.Query(new LichThiDauQueryModel()
                {
                    IdDoi = _IdDoi,
                    SBTDOI = _SBTDOI,
                    IdGiai = _IdGiai,
                    ThoiThiDau = _ThoiThiDau
                });
                msds.Columns[0].Visible = false;
                msds.Columns[1].HeaderText = "Tên Giải";
                msds.Columns[2].HeaderText = "Tên Đội 1";
                msds.Columns[3].HeaderText = "Tên Đội 2";
                msds.Columns[4].HeaderText = "Thời Gian Thi Đấu";
            }
            catch (Exception)
            {
                message.Message();
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            matrandau = txt_matrandau.Text;
            doi1 = txt_doi1.Text;
            doi2 = txt_doi2.Text;
            isStatus = true;
            this.Close();
            Dispose();
        }

        private void msds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex < 0 ? 0 : e.RowIndex;
            txt_matrandau.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[0].Value.ToString();
            txt_muagiai.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[1].Value.ToString();
            txt_doi1.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[2].Value.ToString();
            txt_doi2.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[3].Value.ToString();
            txt_thoigian.Text = e.RowIndex < 0 ? null : msds.Rows[dong].Cells[4].Value.ToString();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            isStatus = false;
            this.Close();
            Dispose();
        }
    }
}
