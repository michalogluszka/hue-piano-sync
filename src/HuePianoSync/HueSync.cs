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
        private static string _hueBridgeIp = "192.168.68.110";
        private const string _appKey = "wV469ndS78sATFa0n8TgAfkwAJ4Mbu2pFK5jCjhk";

        private ILocalHueClient _client;

        public void Initialize()
        {
            _client = new LocalHueClient(_hueBridgeIp);
            _client.Initialize(_appKey);            
        }

        public void Play()
        {         

            var waitTime = 2000;

            Task.Delay(waitTime).Wait();

            var cmdOn = new LightCommand();
            cmdOn.TurnOn();

            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.GardenLeft });

            Task.Delay(waitTime).Wait();


            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.GardenMiddle });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.GardenRight });
            Task.Delay(waitTime).Wait(); ;


            var cmdOff = new LightCommand();
            cmdOff.TurnOff();
            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.GardenRight });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.GardenMiddle });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.GardenLeft });
            Task.Delay(waitTime).Wait(); ;


        }


    }
}
