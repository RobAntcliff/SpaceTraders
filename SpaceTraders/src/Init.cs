using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpaceTraders.Client;
using SpaceTraders.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using SpaceTraders.Client.Register;

namespace SpaceTraders.src
{
    public class Init
    {
        SpaceTradersClient client;

        public Init(){
            this.client = Client.AnonymousClient();
        }

        public Init(SpaceTradersClient client){
            this.client = client;
        }

        public async void CreateNewAgent(string username, FactionSymbol faction){
            var registerJson = new RegisterPostRequestBody
            {
                Symbol = username,
                Faction = faction,
            };

            Console.WriteLine("Registering new agent");
            var register = await client.Register.PostAsRegisterPostResponseAsync(registerJson);

            StoreAgentKey(register?.Data?.Token);
        }

        public async void StoreAgentDetails(){
            using var db = new AgentContext();

            var agent = await client.My.Agent.GetAsAgentGetResponseAsync();

            Console.WriteLine("Inserting agent data to DB");
            if(agent != null){
                db.Add(Agent.makeAgent(agent));
                db.SaveChanges();
            }
        }

        private void StoreAgentKey(string key){
            File.WriteAllText(@"supersecretkey.txt", $"Bearer {key}");
        }
    }
}