using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace vc2_loader_csharp
{
    public partial class Entity : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public Image Image
        {
            get { return pctImage.BackgroundImage; }
            set { pctImage.BackgroundImage = value; }
        }

        public Font normalTitle;
        public Font hoveredTitle;
        
        public void loadImage()
        {
            WebClient wc = new WebClient();
            try { 
                Stream x = wc.OpenRead("https://pp.vk.me/c322116/v322116620/2b9a/9bHEZ77u4sA.jpg?" + this.Title);
                Image = Image.FromStream(x);
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }

        public Entity()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Center;
            loadImage();

            lblTitle.MouseEnter += Entity_MouseEnter;
            pctImage.MouseEnter += Entity_MouseEnter;
            pctLine.MouseEnter  += Entity_MouseEnter;
            pnlImg.MouseEnter   += Entity_MouseEnter;


            lblTitle.MouseLeave += Entity_MouseLeave;
            pctImage.MouseLeave += Entity_MouseLeave;
            pctLine.MouseLeave  += Entity_MouseLeave;
            pnlImg.MouseLeave   += Entity_MouseLeave;

            normalTitle = lblTitle.Font;
            hoveredTitle = new Font(normalTitle, FontStyle.Underline);

            DoubleBuffered = true;
        }
        
        private void Entity_MouseEnter(object sender, System.EventArgs e)
        {
            BackColor = Color.Gainsboro;
            lblTitle.Font = hoveredTitle;
        }
        
        private void Entity_MouseLeave(object sender, System.EventArgs e)
        {
            BackColor = Color.White;
            lblTitle.Font = normalTitle;
        }

        private void Entity_Load(object sender, System.EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, System.EventArgs e)
        {

        }
    }
}
