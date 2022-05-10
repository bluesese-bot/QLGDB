using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QLGDB.Controller
{
    public partial class fr_Main : Form
    {
        private Form activeForm;
        private Button currentButton;
        public fr_Main()
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
        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new fr_Trangchu());
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new fr_QuanLyGiai());
        }

        private void fr_Main_Load(object sender, System.EventArgs e)
        {
            OpenChildForm(new fr_Trangchu());
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            OpenChildForm(new fr_QuanLyThiDau());
        }
    }
}
