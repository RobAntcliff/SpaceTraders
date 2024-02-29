using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SpaceTraders.Client.Models;
using ModelsShip = SpaceTraders.Client.Models.Ship;

namespace SpaceTraders.src
{
    public class Ship
    {
        ModelsShip ship;
        public Ship(ModelsShip ship)
        {
            this.ship = ship;
        }

        public async Task<bool> isFuelFull(){
            //If the fuel data is in the db, check there

            //If not, run  query to get the fuel
            var client = await AuthenticationClient.Client;

            

        }

        public async void goToNearestMiningSpot()
        {

        }

        public async Task<ModelsShip> getUpdatedShipInfo(){
            return await client.My.Ships.GetAsShipsGetResponseAsync();
        }
    }
}