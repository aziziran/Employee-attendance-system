using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hozore_karconan
{
    public partial class ToastForm : Form
    {
        public ToastForm(string message, Color backColor)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = backColor;
            this.Size = new Size(300, 50);
            this.TopMost = true;
            this.ShowInTaskbar = false;

            Label lbl = new Label();
            lbl.Text = message;
            lbl.ForeColor = Color.White;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.Font = new Font("Tahoma", 10, FontStyle.Bold);
            this.Controls.Add(lbl);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var screen = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(screen.Width - this.Width - 10, screen.Height - this.Height - 10);

            Timer timer = new Timer();
            timer.Interval = 3000; // نمایش ۳ ثانیه‌ای
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
    }

}
