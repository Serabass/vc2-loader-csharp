using System;
using System.Drawing;
using System.Windows.Forms;

namespace vc2_loader_csharp
{
    public partial class UserMenu : Form
    {
        public frmMain main;

        public UserMenu()
        {
            InitializeComponent();
        }

        private void UserMenu_Shown(object sender, EventArgs e)
        {
            Location = new Point(Location.X + main.pctMenu.Location.X, Location.Y + main.pctMenu.Location.Y);
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
