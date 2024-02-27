using SpaceTraders.Client;
using SpaceTraders.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using System.Runtime.InteropServices;
using SpaceTraders.Client.Register;
using System;
using System.Linq;
using SpaceTraders.Client.My.Ships;
using System.Diagnostics.CodeAnalysis;
using SpaceTraders.Client.My.Ships.Item.Navigate;
using SpaceTraders.Client.My.Ships.Item.Refuel;
using SpaceTraders.Client.My.Ships.Item.Extract;
using SpaceTraders.Client.My.Ships.Item.Sell;
using System.Linq.Expressions;
using SpaceTraders.src;
using Microsoft.EntityFrameworkCore.Update;

using var db = new AgentContext();

try
{
    SpaceTradersClient client;

    if (AuthenticationClient.HasExpired)
    {
        Init init = new Init();
        init.CreateNewAgent("Bobe", FactionSymbol.DOMINION);

        client = await AuthenticationClient.Client;

        init = new Init(client);

        init.StoreAgentDetails();
    }
    else
    {
        client = await AuthenticationClient.Client;
    }

    var status = await client.GetAsGetResponseAsync();

    var agent = await client.My.Agent.GetAsAgentGetResponseAsync();

    Console.WriteLine("Querying for a Agent");
    var dbAgent = db.Agents
    .OrderBy(b => b.AgentId)
    .First();

    Console.WriteLine(dbAgent.StartingFaction);

    //Let's get some ships mining
    var ships = await client.My.Ships.GetAsShipsGetResponseAsync();
    Console.WriteLine(ships.ToString());

    // foreach(Ship ship in ships.Data){
    //     if(ship.Registration.Role == ShipRole.EXCAVATOR){
    //         //get mining
    //     }
    // }

    // Get contract
    var contracts = await client.My.Contracts.GetAsContractsGetResponseAsync();

    foreach (Contract contract in contracts.Data)
    {
        Console.WriteLine(contract.Id);
    }

    // Accept contract
    //var acceptContract = await client.My.Contracts["clt38izsm2lf3s60coadil07m"].Accept.PostAsAcceptPostResponseAsync();

    // View starting location
    var startingLocationInfo = await client.Systems["X1-FM95"].Waypoints["X1-FM95-A1"].GetAsWithWaypointSymbolGetResponseAsync();

    // Find Shipyard
    var shipardWaypoints = await client.Systems["X1-FM95"].Waypoints.GetAsWaypointsGetResponseAsync(x => x.QueryParameters.Traits = "SHIPYARD");


    foreach (Waypoint waypoint in shipardWaypoints.Data)
    {
        var shipsToPurchase = await client.Systems["X1-FM95"].Waypoints[waypoint.Symbol].Shipyard.GetAsShipyardGetResponseAsync();
    }

    //shipyward waypoint = "X1-FM95-H48"

    var buyShipPostPost = new ShipsPostRequestBody
    {
        ShipType = ShipType.SHIP_MINING_DRONE,
        WaypointSymbol = "X1-FM95-H48",
    };

    //var buyShip = await client.My.Ships.PostAsShipsPostResponseAsync(buyShipPostPost);

    ships = await client.My.Ships.GetAsShipsGetResponseAsync();
    Console.WriteLine(ships.Data.ToString());



    // Mine asteroids
    // var asteroids = await client.Systems["X1-FM95"].Waypoints.GetAsWaypointsGetResponseAsync(x => x.QueryParameters.TypeAsWaypointType = WaypointType.ENGINEERED_ASTEROID);
    // Console.WriteLine(asteroids);

    //Mining ship symbol = "BOBE-3"

    //var goToOrbit = await client.My.Ships["BOBE-3"].Orbit.PostAsOrbitPostResponseAsync();

    var moveShipPost = new NavigatePostRequestBody
    {
        WaypointSymbol = "X1-FM95-CD5Z",
    };

    //var moveShip = await client.My.Ships["BOBE-3"].Navigate.PostAsNavigatePostResponseAsync(moveShipPost);

    // var dockShip = await client.My.Ships["BOBE-3"].Dock.PostAsDockPostResponseAsync();

    // var refuelShipBody = new RefuelPostRequestBody
    // {
    //     Units = 1,
    // };

    // var refuelShip = await client.My.Ships["BOBE-3"].Refuel.PostAsRefuelPostResponseAsync(refuelShipBody);

    //var orbitAsteroidIThink = await client.My.Ships["BOBE-3"].Orbit.PostAsOrbitPostResponseAsync();

    var extractBody = new ExtractPostRequestBody
    {

    };

    var mineAsteroid = await client.My.Ships["BOBE-3"].Extract.PostAsExtractPostResponseAsync(extractBody);

    var marketData = await client.Systems["X1-FM95"].Waypoints["X1-FM95-CD5Z"].Market.GetAsMarketGetResponseAsync();

    var shipCargo = await client.My.Ships["BOBE-3"].Cargo.GetAsCargoGetResponseAsync();

    //var dockShip = await client.My.Ships["BOBE-3"].Dock.PostAsDockPostResponseAsync();

    //Docked waypoint = "X1-FM95-CD5Z"

    var marketWaypoints = await client.Systems["X1-FM95"].Waypoints.GetAsWaypointsGetResponseAsync(x => x.QueryParameters.Traits = "MARKET");

    var sellStuffPost = new SellPostRequestBody
    {
        Symbol = TradeSymbol.ICE_WATER,
        Units = 1,
    };

    var sellStuff = await client.My.Ships["BOBE-3"].Sell.PostAsSellPostResponseAsync(sellStuffPost);

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
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}