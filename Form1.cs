using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace vc2_loader_csharp
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private UserMenu menu;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public frmMain()
        {
            InitializeComponent();

            menu = new UserMenu();
            menu.main = this;
        }
        
        private void Brand_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pctSocialVK_Click(object sender, EventArgs e)
        {
            OpenURL("https://vk.com/vice_city_2");
        }

        private void pctSocialYT_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.youtube.com/user/RevTeamHD");
        }

        private void pctSocialIG_Click(object sender, EventArgs e)
        {
            OpenURL("https://instagram.com/revteam");
        }

        private void pctSocialFB_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/revteam");
        }
        
        private void pctLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pctMenu_Click(object sender, EventArgs e)
        {
            menu.Show();
        }
    }
}
