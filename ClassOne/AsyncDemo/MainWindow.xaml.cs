using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using AsyncDemo.Models;

namespace AsyncDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RunDownloadSync();
        }

        private async void btnAsyncExecution_Click(object sender, RoutedEventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            await RunDownloadASync();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            resultTextBox.Text += $"Total execution time: { elapsedMs }";
        }

        private void btnSomeExecution_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                resultTextBox.Text += "************";
            }
        }

        private async Task RunDownloadASync()
        {
            List<string> websites = PrepData();

            foreach (string site in websites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(site));
                ReportWebsiteInfo(results);
            }
        }


        private void RunDownloadSync()
        {
            List<string> websites = PrepData();
            foreach (string site in websites)
            {
                WebsiteDataModel results = DownloadWebsite(site);
                ReportWebsiteInfo(results);
            }
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();

            resultTextBox.Text = "";

            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");
            output.Add("https://www.farsnews.ir");


            return output;
        }

        private WebsiteDataModel DownloadWebsite(string websiteUrl)
        {
            WebsiteDataModel output = new WebsiteDataModel();

            WebClient client = new WebClient();

            output.Url = websiteUrl;
            output.Data = client.DownloadString(websiteUrl);

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultTextBox.Text += $"{ data.Url } downloaded: { data.Data.Length } characters long.{ Environment.NewLine }";
        }


    }
}
