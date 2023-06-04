using Azure.Storage.Blobs;
using System;

namespace ManagedIdentityWithoutUse
{
    internal class Program
    {
        private static string storage_connection_string = "DefaultEndpointsProtocol=https;AccountName=alexeisa;AccountKey=A3E+mlPVnTE3cnk4eFYg8ZNiRPpWiiHNf1m1YZ6e8uLQMpnoSY1wEMr1jOfdKsaFVbzXwCmlBFVP+ASt9Tta4w==;EndpointSuffix=core.windows.net";
        private static string container_name = "data";
        private static string download_path = "C:\\tmp\\sample.txt";
        private static string blob_name = "sample.txt";
        static void Main(string[] args)
        {
            BlobServiceClient _blobServiceClient = new BlobServiceClient(storage_connection_string);

            BlobContainerClient _containerClient = _blobServiceClient.GetBlobContainerClient(container_name);

            BlobClient _blobclient = _containerClient.GetBlobClient(blob_name);

            _blobclient.DownloadTo(download_path);

            Console.WriteLine("File download complete");
            Console.ReadKey();
        }
    }
}
