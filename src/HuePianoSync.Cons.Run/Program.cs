using Q42.HueApi;
using System;
using System.Threading.Tasks;

namespace HuePianoSync.Cons.Run
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Hue!");

            HueSync sync = new HueSync();
            var initTask = sync.Initialize();
            var lights = await initTask;
            
            foreach(var l in lights)
            {
                Console.WriteLine(l.Id);
                Console.WriteLine(l.Name);
            }
           
        }
    }
}
