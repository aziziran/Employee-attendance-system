using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;



namespace Hozore_karconan
{
    public partial class jhg : Form
    {

        public User LoggedInUser { get; set; }

        public jhg()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoggedInUser != null && LoggedInUser.Role.ToLower() == "public")
            {
                xuiButton5.Visible = false;
                xuiButton6.Visible = false;
                xuiButton7.Visible = false;

              
            }
        }

  

      

        private void jhg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // بستن کل برنامه
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            sabtekarmand FM = new sabtekarmand();
            FM.ShowDialog();
        }

        private void xuiButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "این قابلیت در نسخه Demo غیرفعال است.",
       "Demo Version",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information);

        }

        private void xuiButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
       "این قابلیت در نسخه Demo غیرفعال است.",
       "Demo Version",
       MessageBoxButtons.OK,
       MessageBoxIcon.Information);
        }

        private void xuiButton3_Click(object sender, EventArgs e)
        {
            FrmMain FR = new FrmMain();
            FR.ShowDialog();
        }

        private void xuiButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void xuiButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }

        private void xuiButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
      "این قابلیت در نسخه Demo غیرفعال است.",
      "Demo Version",
      MessageBoxButtons.OK,
      MessageBoxIcon.Information);
        }
    }
}
