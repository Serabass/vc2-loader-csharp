using System.Windows.Forms;
using System.Collections.Generic;

namespace vc2_loader_csharp
{
    public partial class frmMain
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void InitWorkspaces()
        {
            InitCarsWS();
        }

        private void InitCarsWS()
        {
            int i = 0;
            List<string> names = new List<string>();
            names.Add("Landstalker");
            names.Add("Idaho");
            names.Add("Rhino");
            names.Add("Perenial");
            names.Add("Sanchez");
            names.Add("Barracks");
            Panel pnl = new Panel();
            wsCars.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            foreach (string name in names)
            {
                if (i % 3 == 0)
                {
                    pnl = new Panel();
                    pnl.Dock = DockStyle.Top;
                    pnl.Height = 341;
                    wsCars.Controls.Add(pnl);
                }

                Panel el = new Panel();
                Entity x = new Entity();
                x.Title = name;
                x.Dock = DockStyle.Fill;
                el.Padding = el.Margin = new Padding(20, 15, 20, 15);
                el.Width = 270;
                el.Dock = DockStyle.Left;
                el.Controls.Add(x);
                pnl.Controls.Add(el);
                i++;
            }
        }
    }
}
