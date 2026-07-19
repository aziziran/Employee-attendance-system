
using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace Hozore_karconan
{
    public partial class DashboardForm : Form
    {
        private UserBLL userBLL = new UserBLL();

        TextBox txtFullName;
        TextBox txtUsername;
        TextBox txtPassword;
        ComboBox cmbRole;
        Button btnSubmit;

        public DashboardForm()
        {
            InitializeComponent();
            InitUI();
            this.TopMost = true;
        }

        private void InitUI()
        {
            this.Text = "فرم ثبت اطلاعات کاربر";
            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Font = new Font("Tahoma", 14);

            //Label lblTitle = new Label
            //{
            //    Text = "ثبت اطلاعات کاربر",
            //    Font = new Font("Tahoma", 20, FontStyle.Bold),
            //    AutoSize = false,
            //    Height = 60,
            //    Dock = DockStyle.Top,
            //    TextAlign = ContentAlignment.MiddleCenter,
            //    ForeColor = Color.MidnightBlue
            //};
            //this.Controls.Add(lblTitle);

            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Top,
                Padding = new Padding(25),
                ColumnCount = 2,
                RowCount = 5,
                AutoSize = true,
            };

            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));

            txtFullName = new TextBox { Width = 320, Height = 35, Font = new Font("Tahoma", 14) };
            txtUsername = new TextBox { Width = 320, Height = 35, Font = new Font("Tahoma", 14) };
            txtPassword = new TextBox { Width = 320, Height = 35, Font = new Font("Tahoma", 14), UseSystemPasswordChar = true };
            cmbRole = new ComboBox
            {
                Width = 320,
                Font = new Font("Tahoma", 14),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbRole.Items.Add("کاربر عادی");
            cmbRole.SelectedIndex = 0;

            layout.Controls.Add(new Label { Text = "نام و نام خانوادگی:", Anchor = AnchorStyles.Right, AutoSize = true, Font = new Font("Tahoma", 14) }, 0, 0);
            layout.Controls.Add(txtFullName, 1, 0);

            layout.Controls.Add(new Label { Text = "نام کاربری:", Anchor = AnchorStyles.Right, AutoSize = true, Font = new Font("Tahoma", 14) }, 0, 1);
            layout.Controls.Add(txtUsername, 1, 1);

            layout.Controls.Add(new Label { Text = "رمز عبور:", Anchor = AnchorStyles.Right, AutoSize = true, Font = new Font("Tahoma", 14) }, 0, 2);
            layout.Controls.Add(txtPassword, 1, 2);

            layout.Controls.Add(new Label { Text = "نقش:", Anchor = AnchorStyles.Right, AutoSize = true, Font = new Font("Tahoma", 14) }, 0, 3);
            layout.Controls.Add(cmbRole, 1, 3);

            this.Controls.Add(layout);

            btnSubmit = new Button
            {
                Text = "ثبت اطلاعات",
                Width = 220,
                Height = 50,
                Font = new Font("Tahoma", 16, FontStyle.Bold),
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Bottom,
            };
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Location = new Point((this.ClientSize.Width - btnSubmit.Width) / 2, this.ClientSize.Height - btnSubmit.Height - 40);

            btnSubmit.Click += BtnSubmit_Click;

            this.Controls.Add(btnSubmit);




        }
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            if (role == "کاربر عادی")
                role = "public";

            // بررسی فقط نام کاربری (Username)
            if (userBLL.IsUsernameDuplicate(username))
            {
                MessageBox.Show("این نام کاربری قبلاً ثبت شده است.", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                userBLL.RegisterUser(fullName, username, password, role);

                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFullName.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ثبت اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void BtnSubmit_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        //        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        //        string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string fullName = txtFullName.Text.Trim();
        //    string username = txtUsername.Text.Trim();
        //    string password = txtPassword.Text.Trim();
        //    string role = cmbRole.SelectedItem.ToString();

        //    if (role == "کاربر عادی")
        //        role = "public";

        //    // بررسی تکراری بودن کامل (FullName + Username + Password)
        //    if (userBLL.IsDuplicateUser(fullName, username, password))
        //    {
        //        MessageBox.Show("کاربری با همین اطلاعات قبلاً ثبت شده است.", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        userBLL.RegisterUser(fullName, username, password, role);

        //        MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtFullName.Clear();
        //        txtUsername.Clear();
        //        txtPassword.Clear();
        //        cmbRole.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطا در ثبت اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void BtnSubmit_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        //        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        //        string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string role = cmbRole.SelectedItem.ToString();
        //    if (role == "کاربر عادی")
        //        role = "public";

        //    try
        //    {
        //        userBLL.RegisterUser(
        //            txtFullName.Text.Trim(),
        //            txtUsername.Text.Trim(),
        //            txtPassword.Text.Trim(),
        //            role);

        //        MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtFullName.Clear();
        //        txtUsername.Clear();
        //        txtPassword.Clear();
        //        cmbRole.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطا در ثبت اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void BtnSubmit_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        //        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        //        string.IsNullOrWhiteSpace(txtPassword.Text))
        //    {
        //        MessageBox.Show("لطفاً تمام فیلدها را پر کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string username = txtUsername.Text.Trim();

        //    if (userBLL.IsUsernameTaken(username ))
        //    {
        //        MessageBox.Show("این نام کاربری قبلاً ثبت شده است.", "تکراری", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string role = cmbRole.SelectedItem.ToString();
        //    if (role == "کاربر عادی")
        //        role = "public";

        //    try
        //    {
        //        userBLL.RegisterUser(
        //            txtFullName.Text.Trim(),
        //            username,
        //            txtPassword.Text.Trim(),
        //            role);

        //        MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtFullName.Clear();
        //        txtUsername.Clear();
        //        txtPassword.Clear();
        //        cmbRole.SelectedIndex = 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطا در ثبت اطلاعات: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load_1);
            this.ResumeLayout(false);

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
