using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HuePianoSync
{
    public class HueSync
    {
        private const string _hueBridgeIp = "192.168.68.110";
        private const string _appKey = "wV469ndS78sATFa0n8TgAfkwAJ4Mbu2pFK5jCjhk";


        public Task<IEnumerable<Light>> Initialize()
        {
            ILocalHueClient client = new LocalHueClient(_hueBridgeIp);
            client.Initialize(_appKey);

            return client.GetLightsAsync();
        }


    }
}
