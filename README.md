# Codewars.API
Codewars.API is a .NET wrapper for the codewars.com REST API.  It facilitates easy access to the codewars API with static typing, async programming models, and full xdoc as documented on their site. It lets you do all kinds of interesting things like searching for businesses, getting user comments and ratings, and handling common errors.  The library is written C#, and is available on NuGet.  

For more information, visit the [codewars REST API](http://dev.codewars.com/)

## Installing 
In most cases, you're going to want to install the Codewars.API NuGet package.  Open up the Package Manager Console in Visual Studio, and run this command:

```
PM> Install-Package Codewars.API
```

## How to Use
The source includes a [few examples](https://github.com/jacerhea/Codewars.API/tree/master/src/Codewars.API.IntegrationTests) that should help you get started with ASP.NET.

### Handling Tokens
The `CodewarsClient` constructor takes an API key which can be found on the account settings page (https://www.codewars.com/users/edit).  Keep this keys safe!  You can put them in the applicationSettings portion of your web.config (recommended), or store them in an environment variable on your dev machine:

```csharp
var client = new CodewarsClient("My API Key");
var response = client.GetUser("jacerhea");
```

### Using the Search API
Codewars.API uses the [ASP.NET Web API client(TPL)](http://www.asp.net/web-api) to make managing asynchronous requests easier.

```csharp
var task = y.Search("coffee", "seattle, wa").ContinueWith((searchResults) =>
{
    foreach (var business in searchResults.Result.businesses)
    {
        Console.WriteLine(business.name);
    }
});
```

There are a lot of other ways to search.  For more info, the best place to look is the [integration tests](https://github.com/jacerhea/Codewars.API/tree/master/src/Codewars.API.IntegrationTests).


## Building the Source
If you want to build the source, clone the repository, and open up Codewars.API.sln.  

```
git clone https://github.com/jacerhea/Codewars.API.git
explorer src\Codewars.API.sln
```

## Supported Platforms
Codewars.API targets .NET 4.5.  If you would like support for other platforms, let me know.  


## License
[MIT License](http://opensource.org/licenses/MIT)

## Questions?
Feel free to submit an issue on the repository, or find me at [@jacerhea](http://twitter.com/jacerhea)





