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
    public partial class fr_QuanLyThiDau : Form
    {
        public fr_QuanLyThiDau()
        {
            InitializeComponent();
            OpenChildForm(new fr_LichThidau());
        }
        private Form activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(childForm);
            this.pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void lịchThiĐấuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_LichThidau());
        }

        private void tỷSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_TySo());
        }

        private void chungKếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_ChungKet());
        }
    }
}
