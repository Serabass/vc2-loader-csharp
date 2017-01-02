using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;

namespace vc2_loader_csharp
{
    public partial class frmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        
        private UserMenu menu;
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);

        [DllImport("user32.dll")]
        static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        List<LinkLabel> links = new List<LinkLabel>();
        List<Workspace> workspaces = new List<Workspace>();

        public frmMain()
        {
            InitializeComponent();

            menu = new UserMenu();
            menu.main = this;

            InitWorkspaces();

            initLinks();

            IntPtr _RegionHandle = CreateRoundRectRgn(0, 0, Width, Height, 20, 20);
            Region _Region = Region.FromHrgn(_RegionHandle);
            SetWindowRgn(this.Handle, _RegionHandle, true);

            wsCars.Show();
        }

        private void initLinks()
        {
            links.Add(lnkContacts);
            links.Add(lnkDownloads);
            links.Add(lnkInProgress);
            links.Add(lnkMostPopular);
            links.Add(lnkNewReleases);
            links.Add(lnkNews);
            links.Add(lnkSettings);
            links.Add(lnkCars);
            links.Add(lnkMap);
            links.Add(lnkMusic);
            links.Add(lnkTextures);
            links.Add(lnkGuns);

            foreach (LinkLabel lnk in links)
            {
                lnk.LinkClicked += new LinkLabelLinkClickedEventHandler(linkSelected);
            }

            workspaces.Add(wsCars);
            workspaces.Add(wsMap);
            workspaces.Add(wsNewReleases);
        }
        
        private void linkSelected(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (LinkLabel link in links)
            {
                setLinkInactive(link);
            }

            setLinkActive((LinkLabel)sender);
        }

        private void setLinkActive(LinkLabel lnk)
        {
            lnk.Enabled = false;
            lnk.BackColor = Color.FromArgb(50, 100, 100, 100);

            foreach (Workspace ws in workspaces)
            {
                ws.Hide();
            }

            switch (lnk.Name)
            {
                case "lnkCars":
                    wsCars.Show();
                    break;

                case "lnkMap":
                    wsMap.Show();
                    break;

                case "lnkNewReleases":
                    wsNewReleases.Show();
                    break;
            }
        }

        private void setLinkInactive(LinkLabel lnk)
        {
            lnk.Enabled = true;
            lnk.BackColor = Color.WhiteSmoke;
        }

        private void Brand_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
        
        private void pnlContainer_Scroll(object sender, ScrollEventArgs e)
        {
            // pnlContainer.Refresh();
        }
        
        private void pctMenu_Click_1(object sender, EventArgs e)
        {
            Control th = (Control)sender;
            ctxSettings.Show(th, 0, th.Height);
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wsNewReleases_Load(object sender, EventArgs e)
        {

        }
    }
}
