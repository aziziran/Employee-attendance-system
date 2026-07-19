using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hozore_karconan
{
    public partial class sabtekarmand : Form
    {
        public sabtekarmand()
        {
            InitializeComponent();
        }

        private void sabtekarmand_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void ClearFormFields()
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            textBoxX5.Text = "";
            pictureBox1.Image = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxX1.Text) ||
                string.IsNullOrWhiteSpace(textBoxX2.Text) ||
                string.IsNullOrWhiteSpace(textBoxX3.Text) ||
                string.IsNullOrWhiteSpace(textBoxX5.Text) ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("لطفاً تمام فیلدها را تکمیل کرده و تصویر را انتخاب نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string warningMessage = "لطفاً در ثبت اطلاعات دقت نمایید.\nپس از ثبت، امکان ویرایش وجود ندارد";

            bool confirmed = ConfirmDialog.ShowDialog(warningMessage);
            if (!confirmed)
            {
                return;
            }

            var emp = new Employee
            {
                FirstName = textBoxX1.Text.Trim(),
                LastName = textBoxX2.Text.Trim(),
                FatherName = textBoxX3.Text.Trim(),
                NationalCode = textBoxX5.Text.Trim(),
                Picture = ImageToByteArray(pictureBox1.Image)
            };

            var manager = new EmployeeBLL();

            try
            {
                manager.Add(emp);
                MessageBox.Show("کارمند با موفقیت ذخیره شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // ✅ پاک‌سازی فیلدها پس از ثبت موفق
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا در ذخیره‌سازی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "تصاویر (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
