using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace vc2_loader_csharp
{
    public partial class SocialLink : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string URL
        {
            get;
            set;
        }

        private Color backColorNormal;
        private Color backColorHover;

        private Size desiredSize = new Size(35, 49);
        public override Size MinimumSize
        {
            get { return desiredSize; }
            set { }
        }

        public override Size MaximumSize
        {
            get { return desiredSize; }
            set { }
        }

        public SocialLink()
        {
            InitializeComponent();
        }

        private void OpenURL(string url = null)
        {
            if (url != null)
            {
                url = this.URL;
            }
            Process.Start(url);
        }
        
        private void SocialLink_Click(object sender, EventArgs e)
        {
            OpenURL(this.URL);
        }

        private void SocialLink_MouseEnter(object sender, EventArgs e)
        {

        }

        private void SocialLink_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
