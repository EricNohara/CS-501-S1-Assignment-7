using YoutubeDLSharp;

namespace Youtube_Downloader_Console_With_Progress_Bar;

internal class YoutubeDownloader
{
    public static readonly string DOWNLOAD_PATH = "C:\\transfer\\YouTube";
    private YoutubeDL ytdlp;

    public YoutubeDownloader()
    {
        ytdlp = new YoutubeDL();
    }

    // helper function for downloading the video from the url
    public async Task DownloadFromUrl(string url)
    {
        // ensure that the output directory exists
        if (!Directory.Exists(DOWNLOAD_PATH))
        {
            Directory.CreateDirectory(DOWNLOAD_PATH);
        }

        // point to the local executable file gotten from their documentation
        ytdlp.YoutubeDLPath = "../../../lib/yt-dlp.exe";

        // set FFmpeg for combining audio with video
        ytdlp.FFmpegPath = "../../../lib/ffmpeg.exe";

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
}
