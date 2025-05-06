using PRA_B4_FOTOKIOSK.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PRA_B4_FOTOKIOSK.magie
{
    public class SearchManager
    {

        public static Home Instance { get; set; }

        public static void SetPicture(string path)
        {
            Instance.imgBig.Source = pathToImage(path);
        }

        public static BitmapImage pathToImage(string path)
        {
            var stream = new MemoryStream(File.ReadAllBytes(path));
            var img = new System.Windows.Media.Imaging.BitmapImage();

            img.BeginInit();
            img.StreamSource = stream;
            img.EndInit();

            return img;
        }

        public static string GetSearchInput()
        {
            return Instance.tbZoeken.Text;
        }

        public static void SetSearchImageInfo(string text)
        {
            Instance.lbSearchInfo.Content = text;
        }

        public static string GetSearchImageInfo()
        {
            return (string)Instance.lbSearchInfo.Content;
        }

        public static void AddSearchImageInfo(string text)
        {
            SetSearchImageInfo(GetSearchImageInfo() + text);
        }
    }
}
