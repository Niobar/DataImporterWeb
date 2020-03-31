using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MJDataImporterWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Record> listRecords = new List<Record>();
            string currentDirectory = Directory.GetCurrentDirectory();
            for (int j = 1; j < 3; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    string webAdress = @"http://www.trt.net.tr/televizyon/akis.aspx?kanal=trt-" + j + @"&gun=" + i;
                    WebClient webClient = new WebClient(); // can this be outside of loop ?
                    string downloadedData = webClient.DownloadString(webAdress);
                    string pathToFile = Path.Combine(currentDirectory, "downloadedDataTRT" + j + "Day" + i + ".txt");
                    File.WriteAllText(pathToFile, downloadedData);
                }
            }
        }
    }
}
