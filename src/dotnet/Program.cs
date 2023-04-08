using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var apiKey = Environment.GetEnvironmentVariable("DAPPRADARAPIKEY");

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("X-BLOBR-KEY", apiKey);


var httpResult = await httpClient.GetAsync("https://api.dappradar.com/4tsxo4vuhotaojtl/dapps?resultsPerPage=10");

var jsonString = await httpResult.Content.ReadAsStringAsync();

Console.WriteLine(jsonString);