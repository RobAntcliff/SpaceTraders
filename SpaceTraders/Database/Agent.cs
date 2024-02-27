using Microsoft.EntityFrameworkCore;
using SpaceTraders.Client.My.Agent;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

public class AgentContext : DbContext
{
    public DbSet<Agent> Agents { get; set; }

    public string DbPath { get; }

    public AgentContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "spaceTraders.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class Agent
{
    public static Agent makeAgent(AgentGetResponse agentGetResponse)
    {
        return new Agent
        {
            AccountId = agentGetResponse.Data.AccountId,
            Symbol = agentGetResponse.Data.Symbol,
            Headquarters = agentGetResponse.Data.Headquarters,
            Credits = (long)agentGetResponse.Data.Credits,
            StartingFaction = agentGetResponse.Data.StartingFaction,
            ShipCount = (int)agentGetResponse.Data.ShipCount,
        };
    }

    public int AgentId { get; set; }
    public string AccountId { get; set; }
    public string Symbol { get; set; }
    public string Headquarters { get; set; }
    public long Credits { get; set; }
    public string StartingFaction { get; set; }
    public int ShipCount { get; set; }
}

