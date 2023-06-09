// Give contributor access to the managed identity to the VM and Reader access to the resource group

$response = Invoke-WebRequest -Uri 'http://169.254.169.254/metadata/identity/oauth2/token?api-version=2018-02-01&resource=https%3A%2F%2Fmanagement.azure.com%2F' -Headers @{Metadata="true"}

$content =$response.Content | ConvertFrom-Json

$access_token = $content.access_token



$vmInfo = (Invoke-WebRequest -Uri 'https://management.azure.com//subscriptions/bfa5a4b9-6992-4ebd-a737-d73392fe7dba/resourceGroups/alexeirg/providers/Microsoft.Compute/virtualMachines/demovm?api-version=2017-12-01' -Method GET -ContentType "application/json" -Headers @{ Authorization ="Bearer $access_token"}).content

$vmInfo