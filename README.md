# Rocket_Elevators_Customer_Portal
# ..-•~¹°”ˆ˜¨ Overview ¨˜ˆ”°¹~•-..

The purpose of this assignment is to establish an understanding of the theme “Understanding the ASP.NET Framework” of the CodeBoxx "Odyssey", which lasts fourteen (14) weeks

## 𝓘𝓷𝓼𝓽𝓪𝓵𝓵𝓪𝓽𝓲𝓸𝓷

In powershell, Use the following commands to install the correct packages.

```powershell
dotnet new mvc -o MyApp
code -r MyApp
dotnet dev-certs https --trust
```
Run the following command to scaffold a controller, model, and view.
```powershell
 dotnet-aspnet-codegenerator controller -name HelloController -m Example -dc MvcHelloContext  
```

Now, add your NuGet Packages
```powershell
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
Use the h switch to get help on the aspnet-codegenerator controller command
```powershell
dotnet aspnet-codegenerator controller -h
```
Now, to initialise the installation, run these commands.
```powershell
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## 𝓤𝓼𝓪𝓰𝓮

The end goal of this project is to do the following:

**Authentication page**:
Access must be restricted to Rocket Elevators customers, and they must first authenticate before they can reach the main page. It is therefore important to leverage the possibilities offered by .NET to set up this element of the project.
New customers should also be able to register using their email address used in the MySQL database. As the customer portal is not directly connected to the latter, it is using your API that you will check whether the new user is indeed present in the Customers table.

**Home page**:
Once authenticated, the customer goes to the home page. This must contain a menu allowing access to the various features of the portal. The developer is free to integrate any element they deem relevant, such as graphics, statistics, links of interest, etc.

**Product management pages**:
The customer will have the opportunity to see the details of the different products purchased from us, namely batteries, columns and elevators. Each item will provide direct access to the intervention request form, which should be automatically assigned to the selected product. He will also be able to modify his personal information, such as addresses or contact details.


**Intervention request form**:
The customer will find the same form there as the one accessible by Rocket Elevators employees on the main website. However, it will have to be adapted so that the Author and CustomerID columns are automatically assigned to the customer making the request. 

**New MySQL Database**:
To enable client authentication on the portal and role management, a new MySQL database will need to be implemented. This database will be dedicated to user registration.
As for the management of other entities already existing in the system (Customers, Batteries, Columns, Elevators, etc.) it is the existing Rocket Elevators MySQL database that will continue to persist the data. Interaction with these entities will need to be done through the Rocket Elevators API.

**Creation of new requests in the Rocket Elevators API**:
The Rocket Elevators API needs to be modified and improved to offer data through new interaction points, which will be used by the features mentioned above. The programmer has the choice of what type of API they want to use, either REST or GraphQL, but are strongly encouraged to use the higher performing version.


## 𝓒𝓸𝓷𝓽𝓻𝓲𝓫𝓾𝓽𝓲𝓸𝓷

Hayleigh Hevener

Brooks Kloppenburg

Digby Laret

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## 𝓡𝓮𝓺𝓾𝓲𝓻𝓮𝓶𝓮𝓷𝓽𝓼
Dotnet Framework

Visual Studio Code

C#

Heroku

Dbeaver
