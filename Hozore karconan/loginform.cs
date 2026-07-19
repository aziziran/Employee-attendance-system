
using System;
using System.Windows.Forms;
using System.Data.Entity;
using BE;
using BLL;

using System.Drawing;

namespace Hozore_karconan
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            this.Text = "ورود به سیستم";
            this.FormClosing += new FormClosingEventHandler(this.loginform_FormClosing);


        }

        UserBLL bll = new UserBLL();

        private void loginform_Load(object sender, EventArgs e)
        {
          
           txtPassword.KeyPress += txtPassword_KeyPress;


           
            txtUsername.KeyPress += txtUsername_KeyPress; // فیلتر ورود فقط حروف
        }

        private void loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
           

               
                Application.Exit(); // بستن کل برنامه
            //}
            //else
            //{
            //    e.Cancel = true; // لغو بستن فرم

            //}
        }

        private void loginform_FormClosing_1(object sender, FormClosingEventArgs e)
        {

        }

        private void btnUserChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "این قابلیت در نسخه Demo غیرفعال است.",
        "Demo Version",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
           frm.ShowDialog();
        }

    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("لطفاً نام کاربری و رمز عبور را وارد کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Enabled = false;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                this.Enabled = true;

                var user = bll.Login(username, password);

                if (user != null)
                {
                    if (user.Role == "Admin" || user.Role == "public")
                    {
                        new ToastForm("ورود موفقیت‌آمیز بود.", Color.SeaGreen).Show();

                        var mainform = new jhg();
                        mainform.LoggedInUser = user; // ارسال اطلاعات کاربر
                        mainform.Show();
                        this.Hide();
                    }
                    else
                    {
                        new ToastForm("شما دسترسی لازم برای ورود ندارید.", Color.IndianRed).Show();
                    }
                }
                else
                {
                    new ToastForm("نام کاربری یا رمز عبور نادرست است.", Color.IndianRed).Show();
                }
            };
            timer.Start();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // فقط اجازه ورود ارقام و کلید Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // جلوگیری از وارد شدن کاراکتر غیرمجاز
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // جلوگیری از ورود کاراکترهای غیر مجاز (مثل عدد یا علامت)
            }
        }
    }
}
