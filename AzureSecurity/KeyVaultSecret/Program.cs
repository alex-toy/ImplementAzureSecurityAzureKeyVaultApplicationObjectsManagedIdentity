﻿using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;

namespace KeyVaultSecret
{
    internal class Program
    {

        private static string keyvault_url = "https://kvalexei.vault.azure.net/";
        private static string secret_name = "dbpassword";

        static void Main(string[] args)
        {

            TokenCredential _credential = new DefaultAzureCredential();

            SecretClient _secret_client = new SecretClient(new Uri(keyvault_url), _credential);

            var secret = _secret_client.GetSecret(secret_name);

            Console.WriteLine($"The value of the secret is : {secret.Value.Value}");

            Console.ReadKey();

        }
    }
}
