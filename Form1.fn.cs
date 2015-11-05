
namespace vc2_loader_csharp
{
    public partial class frmMain
    {
        public void OpenURL(string url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
