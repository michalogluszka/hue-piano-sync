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
            var init = await initTask;            
        }
    }
}
