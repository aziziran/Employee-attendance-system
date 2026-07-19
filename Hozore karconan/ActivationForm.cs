
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using BLL;

namespace Hozore_karconan
{
    public partial class ActivationForm : Form
    {
        private UserBLL bll = new UserBLL();

        public ActivationForm()
        {
            InitializeComponent();
            this.Text = "ثبت مدیر یا کاربر جدید";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }


        loginform lo = new loginform();
        private void ActivationForm_Load(object sender, EventArgs e)
        {

           
            if (bll.AdminExists())
            {
               MessageBox.Show("مدیر سیستم قبلاً ثبت شده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.Close();
            

                return;
            }

            // ابتدا بررسی فعال بودن بر اساس MAC
            string currentMac = GetMacAddress();
            string savedMac = LoadStoredMac();

            if (!string.IsNullOrEmpty(savedMac))
            {
                if (savedMac != currentMac)
                {
                    MessageBox.Show("فعال‌سازی این نرم‌افزار فقط روی این کامپیوتر امکان‌پذیر است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            else
            {
                // اگر فعال‌سازی انجام نشده، ذخیره کن
                SaveMacAddress(currentMac);
            }

            cmbRole.Items.AddRange(new string[] { "مدیر","کاربر معمولی" });
            cmbRole.SelectedIndex = 0;

            SetPlaceholder(txtFullName, "نام و نام خانوادگی");
            SetPlaceholder(txtUsername, "نام کاربری");
            SetPlaceholder(txtPassword, "رمز عبور");

            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.ForeColor == Color.Gray ||
                txtUsername.ForeColor == Color.Gray ||
                txtPassword.ForeColor == Color.Gray)
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = (cmbRole.SelectedIndex == 0) ? "Admin" : "User";

            bll.RegisterUser(txtFullName.Text, txtUsername.Text, txtPassword.Text, role);
            MessageBox.Show("ثبت کاربر با موفقیت انجام شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SetPlaceholder(TextBox textbox, string placeholder)
        {
            textbox.Text = placeholder;
            textbox.ForeColor = Color.Gray;

            textbox.GotFocus += (s, e) =>
            {
                if (textbox.Text == placeholder)
                {
                    textbox.Text = "";
                    textbox.ForeColor = Color.Black;

                    if (textbox == txtPassword)
                    {
                        textbox.UseSystemPasswordChar = false;
                    }
                }
            };

            textbox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    textbox.Text = placeholder;
                    textbox.ForeColor = Color.Gray;

                    if (textbox == txtPassword)
                    {
                        textbox.UseSystemPasswordChar = false;
                    }
                }
            };
        }

        private string GetMacAddress()
        {
            var nic = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up && n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .FirstOrDefault();

            return nic?.GetPhysicalAddress().ToString() ?? string.Empty;
        }

        private string GetAppDataFilePath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(folder, "HozoreKarconan");
            if (!Directory.Exists(appFolder))
                Directory.CreateDirectory(appFolder);
            return Path.Combine(appFolder, "license.dat");
        }

        private void SaveMacAddress(string mac)
        {
            string path = GetAppDataFilePath();
            string encodedMac = EncodeBase64(mac);
            File.WriteAllText(path, encodedMac);
        }

        private string LoadStoredMac()
        {
            string path = GetAppDataFilePath();
            if (File.Exists(path))
            {
                string encodedMac = File.ReadAllText(path);
                return DecodeBase64(encodedMac);
            }
            return null;
        }

        private string EncodeBase64(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        private string DecodeBase64(string base64Encoded)
        {
            try
            {
                var base64EncodedBytes = Convert.FromBase64String(base64Encoded);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch
            {
                return null;
            }
        }

        private void lblTogglePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
