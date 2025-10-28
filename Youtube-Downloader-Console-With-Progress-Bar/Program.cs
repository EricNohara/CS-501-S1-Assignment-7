using Spectre.Console;

namespace Youtube_Downloader_Console_With_Progress_Bar;

class Program
{
    public static async Task Main(string[] args)
    {
        YoutubeDownloader downloader = new YoutubeDownloader();
        string? url = null;

        // infinite loop for url queries
        while (true)
        {
            // reset the url
            url = null;
            AnsiConsole.WriteLine();
            AnsiConsole.MarkupLine("[cyan]Enter the YouTube url to download:[/]");
            // loop to get valid url
            while (url == null)
            {
                url = Console.ReadLine();
                url = string.IsNullOrEmpty(url) ? null : url;
            }

            // try to download the file
            try
            {
                await downloader.DownloadFromUrl(url);
                AnsiConsole.MarkupLine("[green]Success![/] Find the downloaded video at C:\\transfer\\YouTube");
            }
            catch (Exception ex)
            {
                AnsiConsole.MarkupLine($"[red]Error:[/] {ex.Message}");
            }
        }

    }
}