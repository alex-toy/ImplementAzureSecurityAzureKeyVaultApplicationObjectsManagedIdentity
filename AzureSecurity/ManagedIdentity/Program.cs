using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

namespace ManagedIdentity
{
    internal class Program
    {

        private static string tenantid = "5b38c313-3bf3-4f5b-90e6-8e32480e8986";
        private static string clientid = "759a3471-50e9-491d-be15-e752e437fb0f";
        private static string clientsecret = "7_18Q~AiYzKgVUqH4peoaiS.U6E~PNpOot1VSb8G";

        private static string keyvault_url = "https://alexeikv.vault.azure.net/";
        private static string secret_name = "dbpassword";

        static void Main(string[] args)
        {
            ClientSecretCredential _client_secret = new ClientSecretCredential(tenantid, clientid, clientsecret);

            SecretClient _secret_client = new SecretClient(new Uri(keyvault_url), _client_secret);

            var secret = _secret_client.GetSecret(secret_name);

            Console.WriteLine($"The value of the secret is {secret.Value.Value}");

            Console.ReadKey();
        }
    }
}
