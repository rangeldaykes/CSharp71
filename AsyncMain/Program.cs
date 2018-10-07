using System;
using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("AsyncMain!");

            await Task.Delay(1000);

            Console.WriteLine("End!");
            Console.ReadLine();
        }
    }
}
