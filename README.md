# Implement Azure Security - Azure Key Vault, Application Objects , Managed Identity


## User Management

### Role Based Access Management

- in the *Access Control (IAM)* section, clic *Add Role Assignment*
<img src="/pictures/rbac.png" title="role based access management"  width="900">

- add a *Reader* role for the VM to a user
<img src="/pictures/rbac2.png" title="role based access management"  width="900">

- log in as that user, and see that you have access to that VM. 

So far, access to disk, network and other information is forbidden. We need to give access at the resource group level, instead of giving access to each resource individually.

- log in as admin, and go to the resource group

- in the *Access Control (IAM)* section, clic *Add Role Assignment*
<img src="/pictures/rbac5.png" title="role based access management"  width="900">

- add a *Reader* role for the Resource group to the user. This will reflect to all resources in the resource group.
<img src="/pictures/rbac6.png" title="role based access management"  width="900">

- for example, if you go back to Disk, this is now accessible for that user
<img src="/pictures/rbac7.png" title="role based access management"  width="900">

This is because access to that resource is now inherited
<img src="/pictures/rbac8.png" title="role based access management"  width="900">

- but you cannot stop the VM with that user, because you only have Reader access
<img src="/pictures/rbac9.png" title="role based access management"  width="900">


## Application Object

### Application Object - Azure Blob Storage

- install packages
```
Azure.Identity
Azure.Storage.Blobs
```

- in *Azure Active Directory*, go to *App registrations* 
<img src="/pictures/app_object.png" title="application object"  width="900">

- add a new registration for your app
<img src="/pictures/app_object2.png" title="application object"  width="500">

- in the storage account, add the role user to your app
<img src="/pictures/app_object3.png" title="application object"  width="900">

- do the same for the role *Storage Blob Data Reader*

- in the *App Registration*, grab the tenant and client ids need by the application
<img src="/pictures/app_object4.png" title="application object"  width="900">

- in the section *Certificates & secrets*, create a new secret. Grab that secret and use it for the application.
<img src="/pictures/app_object5.png" title="application object"  width="900">


## Azure Key Vault

### Create a Key Vault

- create a *Key Vault* resource
<img src="/pictures/key_vault.png" title="key vault"  width="900">

### Azure Key Vault - Secrets - Application object

- create a *Key Vault* secret
<img src="/pictures/key_vault2.png" title="key vault"  width="900">

- create an access policy
<img src="/pictures/key_vault3.png" title="key vault"  width="500">
<img src="/pictures/key_vault4.png" title="key vault"  width="500">
<img src="/pictures/key_vault5.png" title="key vault"  width="900">

- run the app. You should get the secret
<img src="/pictures/key_vault6.png" title="key vault"  width="500">

### Azure Key Vault - Secrets - Encryption keys

- install packages
```
Azure.Identity
Azure.Security.KeyVault.Keys
Azure.Security.KeyVault.Keys.Cryptography
```

- generate a key
<img src="/pictures/encryption.png" title="key vault"  width="500">
<img src="/pictures/encryption2.png" title="key vault"  width="900">

- add an access policy for the app
<img src="/pictures/encryption3.png" title="key vault"  width="500">
<img src="/pictures/encryption4.png" title="key vault"  width="500">
<img src="/pictures/encryption5.png" title="key vault"  width="900">

- run the app
<img src="/pictures/encryption6.png" title="key vault"  width="900">

### Azure Key Vault - Access Policies vs RBAC

- add a reader role to a user
<img src="/pictures/apvsrbac.png" title="key vault"  width="900">

- now the user should be able to access *Key Vault*

- create an access policy
<img src="/pictures/apvsrbac2.png" title="key vault"  width="900">
<img src="/pictures/apvsrbac3.png" title="key vault"  width="900">

- now the user should have the ability to list the secret

### Managed Identities - without use

- create console app for blob storage, and build it

- create a **Windows 2019 server** VM

- download the .rdp file of the machine

- right-clic and edit the .rdp file and select *local resources*, then map the local C drive. Finally, connect to the VM
<img src="/pictures/without.png" title="managed identities without use"  width="300">
<img src="/pictures/without2.png" title="managed identities without use"  width="300">





https://github.com/cloudxeus/Azure-Dev/tree/main/AZ-204%20-%20Implement%20Azure%20security%20-%20Key%20Vault%2C%20Managed%20Identity/4.%20Case%20-%20Managed%20Identities%20-%20Without%20use/AzureStorageBlob