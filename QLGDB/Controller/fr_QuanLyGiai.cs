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
    public partial class fr_QuanLyGiai : Form
    {
        private Form activeForm;

        public fr_QuanLyGiai()
        {
            InitializeComponent();
        }
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
        private void đăngKýĐộiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_Dangkydoi());
        }

        private void thêmCầuThủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_Themcauthu());
        }

        private void mùaGiảiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fr_Themgiaidau());
        }

        private void fr_QuanLyGiai_Load(object sender, EventArgs e)
        {
            OpenChildForm(new fr_Quanly());
        }
    }
}
