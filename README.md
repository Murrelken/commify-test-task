# Running
Requires .Net 6 SDK and the "ASP.NET and web development" package from VS installer.

https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/install

There is only one profile in launchSettings file in the "Server" project, and running it should start up both back-end and fron-end.

Browser should automatically open on the 7189 https localhost port.

# Frameworks used
- Microsoft.EntityFrameworkCore.InMemory
- xunit
- Moq

# Angular client
The root folder is ./angular-clien

Additionally to the Blazor app, you can start the Angular app from the root folder by running either npm start or ng serve.
Both will start an angular app on the 4200 port with a requests proxy to the "http://localhost:5185", which is a launch setting for the server side.
