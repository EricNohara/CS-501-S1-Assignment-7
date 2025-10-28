using YoutubeDLSharp;
using YoutubeDLSharp.Options;
using Spectre.Console;

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

        // Configure download options for better progress reporting
        var optionSet = new OptionSet()
        {
            NoPart = true,  
            NoPlaylist = true,  
            Format = "best" 
        };

        // attempt to download with progress bar
        await AnsiConsole.Progress()
            .AutoClear(false)
            .StartAsync(async ctx =>
            {
                var task = ctx.AddTask("[green]Downloading video[/]");
                task.MaxValue = 100;

                bool downloadStarted = false;
                bool downloadComplete = false;
                double simulatedProgress = 0;

                var progress = new Progress<DownloadProgress>(p =>
                {
                    // Start progress when preprocessing is done
                    if (p.State == DownloadState.PreProcessing || p.State == DownloadState.Downloading)
                    {
                        downloadStarted = true;
                    }

                    // Mark as complete when we get success state
                    if (p.State == DownloadState.Success)
                    {
                        downloadComplete = true;
                        task.Value = 100;
                        task.Description = $"[green]Complete![/]";
                    }

                    // Update description with download info
                    if (!string.IsNullOrEmpty(p.Data) && p.State != DownloadState.Error)
                    {
                        if (p.Data.Contains("Downloading") || p.Data.Contains("youtube"))
                        {
                            task.Description = $"[green]Downloading video...[/]";
                        }
                    }
                });

                // Start the actual download in the background
                var downloadTask = ytdlp.RunVideoDownload(url, progress: progress, overrideOptions: optionSet);

                // progress while download is running
                while (!downloadComplete)
                {
                    if (downloadStarted && simulatedProgress < 95)
                    {
                        // Start slow, then speed up
                        double increment;
                        if (simulatedProgress < 20)
                        {
                            increment = 0.5; 
                        }
                        else if (simulatedProgress < 50)
                        {
                            increment = 1.5; 
                        }
                        else if (simulatedProgress < 80)
                        {
                            increment = 2.5; 
                        }
                        else
                        {
                            increment = 1.0; 
                        }

                        simulatedProgress += increment;
                        task.Value = simulatedProgress;
                    }

                    await Task.Delay(100); // Update every 100ms

                    // Check if download finished
                    if (downloadTask.IsCompleted)
                    {
                        break;
                    }
                }

                var res = await downloadTask;

                if (!res.Success)
                {
                    throw new Exception($"Download failed: {string.Join(Environment.NewLine, res.ErrorOutput)}");
                }

                task.Value = 100;
            });
    }
}
