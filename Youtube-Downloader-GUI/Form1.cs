using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDLSharp;

namespace Youtube_Downloader_GUI
{
    public partial class Form1 : Form
    {
        public static readonly string DOWNLOAD_PATH = "C:\\transfer\\YouTube";
        private YoutubeDL ytdlp;

        public Form1()
        {
            ytdlp = new YoutubeDL();
            InitializeComponent();
        }

        // helper function for downloading the video from the url
        private async Task DownloadFromUrl(string url)
        {
            // ensure that the output directory exists
            if (!Directory.Exists(DOWNLOAD_PATH))
            {
                Directory.CreateDirectory(DOWNLOAD_PATH);
            }

            // point to the local executable file gotten from their documentation
            ytdlp.YoutubeDLPath = "../../lib/yt-dlp.exe";

            // set FFmpeg for combining audio with video
            ytdlp.FFmpegPath = "../../lib/ffmpeg.exe"; 

            // set output destination to the downloads folder and the output file name template
            ytdlp.OutputFolder = DOWNLOAD_PATH;
            ytdlp.OutputFileTemplate = "%(title)s.%(ext)s";

            // attempt to download
            var res = await ytdlp.RunVideoDownload(url);

            if (!res.Success)
            {
                throw new Exception($"Download failed: {string.Join(Environment.NewLine, res.ErrorOutput)}");
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // disable the button to avoid more than one click event
                btnDownload.Enabled = false;
                lbDownloadStatus.Text = "Beginning download process...";

                // get the url from the text box and ensure it is valid
                string url = tbEnterUrl.Text;
                if (string.IsNullOrEmpty(url))
                {
                    throw new Exception("Inputted url is null or empty");
                }

                // call the download from url function to try to download the video
                lbDownloadStatus.Text = "Downloading...";
                await DownloadFromUrl(url);

                tbEnterUrl.Text = "";
                lbDownloadStatus.Text = "Success! Find the downloaded video at C:\\transfer\\YouTube";
            }
            catch (Exception ex)
            {
                // display the error message
                lbDownloadStatus.Text = $"Error: {ex.Message}";
            } finally
            {
                // re enable the button at the end
                btnDownload.Enabled = true;
            }
        }
    }
}
