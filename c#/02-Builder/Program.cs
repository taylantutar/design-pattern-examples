using _02_Builder;

Console.WriteLine("1");
var url = new UrlBuilder("https:www.google.com")
    .AddParameters("api")
    .AddParameters("v1")
    .AddParameters("user")
    .AddParameters("GetAll")
    .AddQueryParam("id", "1")
    .AddQueryParam("name", "ali")
    .AddQueryParam("surname", "kaya");
Console.Write("---> Url: ");
Console.WriteLine(url.Build());

Console.WriteLine("2");
var url2 = new UrlBuilder("https:www.google.com")
    .AddParameters("user")
    .AddQueryParam("id", "1");
Console.Write("---> Url: ");
Console.WriteLine(url2.Build());

Console.WriteLine("3");
var url3 = new UrlBuilder("https:www.google.com")
    .AddParameters("user");
Console.Write("---> Url: ");
Console.WriteLine(url3.Build());