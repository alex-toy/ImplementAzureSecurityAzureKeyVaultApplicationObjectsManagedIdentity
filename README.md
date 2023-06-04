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
