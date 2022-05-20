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
    public partial class fr_ChungKet : Form
    {
        private readonly LichThiDauService _service = new LichThiDauService();
        private readonly DoiBongService _serviceB = new DoiBongService();
        private readonly GiaiDauService _serviceGD = new GiaiDauService();
        private readonly message message = new message();

        public fr_ChungKet()
        {
            InitializeComponent();
            FilltextMuaGiai();
            txt_muagiai.SelectedIndex = -1;
        }
        protected void FilltextMuaGiai()
        {
            try
            {
                txt_muagiai.DataSource = _serviceGD.Query(new GiaiDauQueryModel { TenGiaiDau = null, ThoiGianBatDau = null, ThoiGianKetThuc = null });
                txt_muagiai.DisplayMember = "TenGiaiDau";
                txt_muagiai.ValueMember = "Id";
            }
            catch (Exception)
            {
                message.Message();
            }
        }
        protected void FillDoi(TextBox box, int IDgiai, int TranDau)
        {
            try
            {
                var doibong = _serviceB.getDoiBong(IDgiai, TranDau);
                box.Text = doibong == null ? "" : doibong.TenDoi;
                box.Tag = doibong == null ? box.Tag : doibong.Id;
                var a = box.Tag;
            }
            catch (Exception)
            {
                message.Message();
            }
        }

        private void txt_muagiai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_muagiai.SelectedIndex >= 0)
            {
                FillDoi(txtDOI1, (int)txt_muagiai.SelectedValue, 1);
                FillDoi(txtDOI2, (int)txt_muagiai.SelectedValue, 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_muagiai.SelectedIndex != -1 && !string.IsNullOrEmpty(txtDOI1.Text) && !string.IsNullOrEmpty(txtDOI2.Text))
                {
                    var res = _service.Add(new LichThiDauAddModel()
                    {
                        IdGiai = Convert.ToInt32(txt_muagiai.SelectedValue),
                        IdDoi1 = Convert.ToInt32(txtDOI1.Tag),
                        IdDoi2 = Convert.ToInt32(txtDOI2.Tag),
                        ThoiThiDau = tm_Thoigian.Value,
                        SBTDOI1 = -1,
                        SBTDOI2 = -1
                    });
                    if (res == false)
                    {
                        message.MessageFalse();
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
        }
    }
}
