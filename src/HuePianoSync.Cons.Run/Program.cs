using Q42.HueApi;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace HuePianoSync.Cons.Run
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello Hue!");

            HueSync sync = new HueSync();
            sync.Initialize();

            sync.Play();

            Console.ReadLine();
           
        }
    }
}
