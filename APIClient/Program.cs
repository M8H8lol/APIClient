using System.Security.AccessControl;
using System;
using System.Text.Json;                                                 //kuk smakar som 12 månaders lagrad ost // Emma
using RestSharp;



RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest pokeRequest = new RestRequest("pokemon/genesect");
IRestResponse pokeResponse = pokeClient.Get(pokeRequest);
// Console.WriteLine(pokeResponse.Content);

Pokemon p = JsonSerializer.Deserialize<Pokemon>(pokeResponse.Content);

Console.WriteLine(p.name);

// RestClient swClient = new RestClient("https://swapi.dev/api/");
// RestRequest swRequest = new RestRequest("people/60");
// IRestResponse swResponse = swClient.Get(swRequest);
// Console.WriteLine(swResponse.Content);

// Person pNis = JsonSerializer.Deserialize<Person>(swResponse.Content);

// Console.WriteLine(pNis.name);

Console.ReadLine();