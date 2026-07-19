using System;
using System.Windows.Forms;

namespace Hozore_karconan
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        public static bool ShowDialog(string message)
        {
            using (var form = new ConfirmDialog(message))
            {
                return form.ShowDialog() == DialogResult.Yes;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
