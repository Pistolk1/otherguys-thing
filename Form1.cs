using System.IO.Compression;
using System.Net;
using System.Net.Http.Headers;
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

        private void button1_Click(object sender, EventArgs e) // Download Single Place Version
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter both Place ID and Version ID.");
                return;
            }

            long placeId, versionId;
            if (!long.TryParse(textBox1.Text, out placeId) || !long.TryParse(textBox2.Text, out versionId))
            {
                MessageBox.Show("Invalid Place ID or Version ID.");
                return;
            }

            string url = "https://assetdelivery.roblox.com/v1/asset/?id=" + placeId + "&versionId=" + versionId;

#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (WebClient client = new WebClient())
            {
                client.Headers[HttpRequestHeader.CacheControl] = "no-cache";
                client.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
                byte[] compressedBytes;
                try
                {
                    compressedBytes = client.DownloadData(url);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Error downloading file: " + ex.Message);
                    return;
                }

                using (GZipStream decompressionStream = new GZipStream(new MemoryStream(compressedBytes), CompressionMode.Decompress))
                {
                    const int blockSize = 1024;
                    byte[] buffer = new byte[blockSize];
                    using (MemoryStream memory = new MemoryStream())
                    {
                        int count = 0;
                        do
                        {
                            count = decompressionStream.Read(buffer, 0, blockSize);
                            if (count > 0)
                            {
                                memory.Write(buffer, 0, count);
                            }
                        }
                        while (count > 0);

                        byte[] decompressedBytes = memory.ToArray();

                        SaveFileDialog saveSingleFile = new SaveFileDialog();
                        saveSingleFile.Filter = "Roblox Place Files (*.rbxl)|*.rbxl";
                        saveSingleFile.Title = "Save Roblox Place File";

                        if (saveSingleFile.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveSingleFile.FileName;
                            File.WriteAllBytes(filePath, decompressedBytes);
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter both Place ID and Version Range.");
                return;
            }

            long placeId, minVersionId, maxVersionId;
            if (!long.TryParse(textBox4.Text, out placeId) ||
                !long.TryParse(textBox3.Text.Split(',')[0], out minVersionId) ||
                !long.TryParse(textBox3.Text.Split(',')[1], out maxVersionId))
            {
                MessageBox.Show("Invalid Place ID or Version Range.");
                return;
            }

            FolderBrowserDialog saveMultipleFiles = new FolderBrowserDialog();
            if (saveMultipleFiles.ShowDialog() == DialogResult.OK)
            {
                string folderPath = saveMultipleFiles.SelectedPath;

                for (long versionId = minVersionId; versionId <= maxVersionId; versionId++)
                {
                    string versionUrl = $"https://assetdelivery.roblox.com/v1/asset/?id={placeId}&versionId={versionId}";
                    using (WebClient client = new WebClient())
                    {
                        client.Headers[HttpRequestHeader.AcceptEncoding] = "gzip";
                        byte[] compressedBytes;
                        try
                        {
                            compressedBytes = client.DownloadData(versionUrl);
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show("Error downloading file: " + ex.Message + "URL: "+ versionUrl);
                            return;
                        }

                        using (GZipStream decompressionStream = new GZipStream(new MemoryStream(compressedBytes), CompressionMode.Decompress))
                        {
                            const int blockSize = 1024;
                            byte[] buffer = new byte[blockSize];
                            using (MemoryStream memory = new MemoryStream())
                            {
                                int count = 0;
                                do
                                {
                                    count = decompressionStream.Read(buffer, 0, blockSize);
                                    if (count > 0)
                                    {
                                        memory.Write(buffer, 0, count);
                                    }
                                }
                                while (count > 0);

                                byte[] decompressedBytes = memory.ToArray();

                                string filePath = Path.Combine(folderPath, $"{placeId}_{versionId}.rbxl");
                                File.WriteAllBytes(filePath, decompressedBytes);
                            }
                        }
                    }
                }
            }
        }
    }
}