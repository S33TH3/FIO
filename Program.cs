using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace FIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Init();
            // Set the URL you want to open
            string url = "https://fiverr.com";

            // Create a timer that ticks every 2 hours (7200 seconds)
            System.Timers.Timer timer = new System.Timers.Timer(2 * 60 * 60 * 1000);
            timer.Elapsed += (sender, e) => OpenUrl(url);
            timer.AutoReset = true;
            timer.Start();

            Console.WriteLine("Press 'Q' to quit the application.");
            while (Console.ReadKey().Key != ConsoleKey.Q)
            {
                // Keep the application running until the user presses 'Q'
            }

            // Stop the timer and exit the application
            timer.Stop();
        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
                Console.WriteLine($"Opened URL: {url} at {DateTime.Now}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open URL: {url}. Error: {ex.Message}");
            }
        }

        private static void Init()
        {
            Console.Title = "Fiverr Inbox Opener - github.com/s33th3/fio";
            Console.WriteLine(@"FiverrInboxOpener - Never forget to make the money to pay your bills again!
Developer: Samuel (github.com/s33th3)
Repository: github.com/s33th3/fio");
        }
    }
}
