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
        public async Task<IEnumerable<LocatedBridge>> Initialize()
        {
            IBridgeLocator locator = new HttpBridgeLocator(); //Or: LocalNetworkScanBridgeLocator, MdnsBridgeLocator, MUdpBasedBridgeLocator
            var bridges = await locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            return bridges;

            
        }
    }
}
