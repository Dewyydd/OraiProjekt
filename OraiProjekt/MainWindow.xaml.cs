using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;
using TagLib;

namespace OraiProjekt
{
    public partial class MainWindow : Window
    {
        string tempFile = "temp.mp3";

        public MainWindow()
        {
            InitializeComponent();
            LoadMusic();
        }

        private void LoadMusic()
        {
            // 🔗 Dropbox DIRECT link (dl.dropboxusercontent!)
            string url = "https://dl.dropboxusercontent.com/s/abcd1234/zene.mp3";

            // letöltés
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(url, tempFile);
            }

            // 🎵 lejátszó beállítás
            player.Source = new Uri(Path.GetFullPath(tempFile));

            // 🖼️ borítókép kiolvasás
            var file = TagLib.File.Create(tempFile);

            if (file.Tag.Pictures.Length > 0)
            {
                var pic = file.Tag.Pictures[0];
                var bin = (byte[])pic.Data.Data;

                using (var ms = new MemoryStream(bin))
                {
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.StreamSource = ms;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.EndInit();

                    albumImage.Source = image;
                }
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }
    }
}