//بِسْمِ اللَّهِ الرَّحْمَنِ الرَّحِيمِ
using System;
using System.Net;

namespace QuranApp
{
    static class QDownloader
    {
        public static string QuranArabicURL = "https://images.qurancomplex.gov.sa/publications/07_wasat/h1024/png/iphone6plus/";
        // public static string[] QuranMp3URL = {"https://download.quranicaudio.com/quran/abdullaah_basfar/001.mp3",
        //                                       "https://download.quranicaudio.com/quran/abdurrahmaan_as-sudays/001.mp3",
        //                                       "https://server6.mp3quran.net/akdr/001.mp3"};
        public static string QuranSaveToPath = @"C:\Main\\Projects\Project Q\QuranApp\Images\Quran_Arabic_Pages\";
        public static void DownloadAll(string url, int start, int end, string savePath, string type = ".png")
        {

            using (var client = new WebClient())
            {
                for (int i = start; i < end + 1; i++)
                {
                    string name = i.ToString("0000") + type;
                    client.DownloadFile(url + name, savePath + name);
                    Console.Clear();
                    Console.WriteLine("Progress: " + i + " / " + end);
                }
            }

        }
    }
}

