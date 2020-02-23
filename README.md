# Super King Markets Example Website
A website dedicated to SK Markets. Written in Asp.net Core MVC

Please support the official website: https://superkingmarkets.com/

## How to run the application
This application was written in .NET Core 2.2. To download the 3.1 environment, visit [here](https://dotnet.microsoft.com/download/dotnet-core/3.1).

To run the application, run the command:
> dotnet run 

The application will then be hosted on https://localhost:5001. 
When you're done with the application, press "Ctrl+C" to close the application.

### Relevant Nuget Packages
Since this applications version of .NET is 2.2, we must use the Newtonsoft JSON package.
Microsoft has since released built in JSON support to .NET applications version 3.0 and up. 
More about it can be learned [here](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-core-3-0#fast-built-in-json-support) 

For this application, I ran this command to download the package through the dot net cli:  
> dotnet add package Newtonsoft.Json -v 12.0.1

Microsoft explains how to download it [here](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-dotnet-cli) 
Read [the official docs](https://www.newtonsoft.com/json/help/html/SerializeObject.htm) to learn about how to serialize and unserialize data.
