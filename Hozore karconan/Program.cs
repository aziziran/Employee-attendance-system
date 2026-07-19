





using System;
using System.Windows.Forms;
using BLL; // فرض بر اینه که کلاس BLL_Admin در این فضای نام هست

namespace Hozore_karconan
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // نمایش فرم SplashScreen به صورت موقت
            using (SplashScreen splash = new SplashScreen())
            {
                splash.ShowDialog();
            }

            // بررسی وجود مدیر (Admin)
            if (IsAdminRegistered())
            {
                Application.Run(new loginform());
            }
            else
            {
                Application.Run(new ActivationForm());
            }


        }

        // متد کمکی برای بررسی اینکه آیا مدیر ثبت شده یا نه
        private static bool IsAdminRegistered()
        {
            UserBLL bll = new UserBLL();
            return bll.AdminExists();
        }
    }
}
