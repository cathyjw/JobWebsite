# Job Project

The project was initialized by following application framework.
https://aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core


## Installation steps:
1. Create a database on lcoal database named "JobDb" 
2. Open "Job" solution in Visual Studio 2019 comminuty Version 16.0.1 and build the solution.
3. Select the 'Web.Mvc' project as the startup project.
4. Check the connection string in the appsettings.json file of the Web.Mvc project, change it if you want.
5. Open Package Manager Console and run the Update-Database command to create tables in "JobDb" database 
(ensure that the Default project is selected as .EntityFrameworkCore in the Package Manager Console window).
6. Run the application. The username is 'admin' and the password is '123qwe' by default. 

## Admin Subfolder in MVC and JavaScript:
Main process:
1. Change namespace
2. Change path in related files  

## Next Step:
1. Try Area
2. ASP.NET core mvc scaffolding layout
3. Partial view (*.cshtml) scaffolding from controller and model
