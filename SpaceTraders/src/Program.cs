﻿using SpaceTraders.Client;
using SpaceTraders.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Runtime.InteropServices;
using SpaceTraders.Client.Register;

string tempKey = File.ReadAllText(@"supersecretkey.txt");

// Create auth provider
//var authProvider = new ApiKeyAuthenticationProvider(tempKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
var authProvider = new AnonymousAuthenticationProvider();
// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider);
// Create the API client
var client = new SpaceTradersClient(adapter);

try
{
    // Register new agent
    var registerJson = new RegisterPostRequestBody
    {
        Symbol = "Bobe",
        Faction = FactionSymbol.DOMINION
    };

    var register = await client.Register.PostAsRegisterPostResponseAsync(registerJson);

    // Write token into supersecrettoken.txt
    File.WriteAllText(@"supersecretkey.txt", $"Bearer: {register?.Data?.Token}");

    // Write agent info to a DB

    // Write Starting Ship Info to DB

    // Get all waypoints in start system & write to DB

    // Get all markets in start system and write to DB

    // Get all shipyards and write to DB



    // var status = await client.GetAsGetResponseAsync();
    // Console.WriteLine(status);

    // var factions = await client.Factions.GetAsFactionsGetResponseAsync();
    // var factionsString = factions.ToString();
    // Console.WriteLine(factionsString);

    // var yokes = await client.My.Agent.GetAsAgentGetResponseAsync();
    // Console.WriteLine(yokes);

    // var location = await client.Systems["X1-ZB92"].Waypoints["X1-ZB92-A1"].GetAsWithWaypointSymbolGetResponseAsync();
    // Console.WriteLine(location);

    // var mission = await client.My.Contracts.GetAsContractsGetResponseAsync();
    // Console.WriteLine(mission);

    // Console.WriteLine(register?.Data?.Token);
    //Console.WriteLine($"Retrieved {allPosts?.Count} posts.");

    // // GET /posts/{id}
    // var specificPostId = 5;
    // var specificPost = await client.Posts[specificPostId].GetAsync();
    // Console.WriteLine($"Retrieved post - ID: {specificPost?.Id}, Title: {specificPost?.Title}, Body: {specificPost?.Body}");

    // // POST /posts
    // var newPost = new Post
    // {
    //     UserId = 42,
    //     Title = "Testing Kiota-generated API client",
    //     Body = "Hello world!"
    // };

    // var createdPost = await client.Posts.PostAsync(newPost);
    // Console.WriteLine($"Created new post with ID: {createdPost?.Id}");

    // // PATCH /posts/{id}
    // var update = new Post
    // {
    //     // Only update title
    //     Title = "Updated title"
    // };

    // var updatedPost = await client.Posts[specificPostId].PatchAsync(update);
    // Console.WriteLine($"Updated post - ID: {updatedPost?.Id}, Title: {updatedPost?.Title}, Body: {updatedPost?.Body}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}