using System.Text;

namespace Roblox_Place_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/qfoxb";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = target, UseShellExecute = true });

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/LockpickInteractive";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = target, UseShellExecute = true });
        }

        private async void button1_Click(object sender, EventArgs e) // Download Single Place Version
        {
            long placeId = long.Parse(textBox1.Text);
            long versionId = long.Parse(textBox2.Text);
            string url = "https://assetdelivery.roblox.com/v1/asset/?id=" + placeId + "&versionId=" + versionId;
            
        }
    }
}

