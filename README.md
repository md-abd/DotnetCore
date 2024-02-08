Asp.Net Core is one of the best technologies in the software market.

The project uses the MVC architecture. This shows the flow of data between the model, view and the controller.
The HttpGet attribute responds to the 'GET' request and gets the data from the server.
The HttpPost attribute responds to the 'POST' request and posts the data to the server.

The Startup.cs file has the connection string for the project. The initial catalog is the name of the database for the project.
For different verions of .net, the connection strings can be specified in different locations. In case of .net 7, we do not have a Startup.cs file. In this case we can specify the connection string in the appsettings.json file.

In this project we are using the Sql server nuilt-in in the Visual Studio. For better and faster execution of commands Microsoft SL Server Management Studio can be used with the project.

There are certain packages that need to be installed for the project to run. They are-
1.Microsoft.EntityFrameworkCore
2.Microsoft.EntityFrameworkCore.SqlServer
3.Microsoft.EntityFrameworkCore.Tools(Migration)
4.Microsoft.VisualStudio.Web.Codegeneration.Design
