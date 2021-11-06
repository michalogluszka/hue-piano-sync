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

            //IEnumerable<Light> lightsRes = _client.GetLightsAsync().Result;
            //foreach(var l in lightsRes)
            //{
            //    Console.WriteLine(l.Name + " " + l.Id);
            //}    


            var waitTime = 2000;

            Task.Delay(waitTime).Wait();

            var cmdOn = new LightCommand();
            cmdOn.TurnOn();

            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.Attick1 });

            Task.Delay(waitTime).Wait();


            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.Attick2 });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOn, new[] { HueHomeConfig.Attick3 });
            Task.Delay(waitTime).Wait(); ;


            var cmdOff = new LightCommand();
            cmdOff.TurnOff();
            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.Attick1 });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.Attick2 });
            Task.Delay(waitTime).Wait(); ;

            _client.SendCommandAsync(cmdOff, new[] { HueHomeConfig.Attick3 });
            Task.Delay(waitTime).Wait(); ;


        }


    }
}
