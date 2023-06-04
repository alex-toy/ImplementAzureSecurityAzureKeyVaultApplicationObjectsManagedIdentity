using Azure.Identity;
using Azure.Storage.Blobs;
using System;

namespace BlobApp
{
    internal class Program
    {
        private static string blob_url = "https://alexeistorageaccount.blob.core.windows.net/data/sample.txt";
        private static string local_blob = "C:\\source\\cSharpAzure\\ImplementAzureSecurityAzureKeyVaultApplicationObjectsManagedIdentity\\sample.txt";

        private static string tenantid = "5b38c313-3bf3-4f5b-90e6-8e32480e8986";
        private static string clientid = "f7d661ee-8f49-439c-ab2c-5fd5abbc8054";
        private static string clientsecret = "eHy8Q~hvntxwwUPOsMdrGIi4FIpRbkinUj0IraYY";

        static void Main(string[] args)
        {
            ClientSecretCredential _client_credential = new ClientSecretCredential(tenantid, clientid, clientsecret);

            Uri blob_uri = new Uri(blob_url);

            BlobClient _blob_client = new BlobClient(blob_uri, _client_credential);

            _blob_client.DownloadTo(local_blob);

            Console.WriteLine("Blob downloaded");
            Console.ReadKey();
        }
    }
}
