using System.Windows.Forms;

namespace vc2_loader_csharp
{
    public partial class Workspace : UserControl
    {
        public Workspace()
        {
            InitializeComponent();
        }
        
        private void Workspace_Scroll(object sender, ScrollEventArgs e)
        {
            this.Refresh();
        }
    }
}
