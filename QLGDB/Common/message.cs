using System.Windows.Forms;

namespace QLGDB.Common
{
    public class message
    {
        public DialogResult Message()
        {
           return MessageBox.Show("Đã có lỗi xảy ra. Vui lòng liên hệ nhà phát triển.", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult MessageFalse()
        {
            return MessageBox.Show("Đã có lỗi xảy ra khi thao tác!!!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult MessageTrue()
        {
            return MessageBox.Show("Thành công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult MessageFild()
        {
            return MessageBox.Show("Các trường không được để thiếu", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public DialogResult Message(string Exception)
        {
            return MessageBox.Show(Exception, "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
