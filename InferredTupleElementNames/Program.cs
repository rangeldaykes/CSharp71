using System;

namespace InferredTupleElementNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InferredTupleElementNames");

            // in c# 7.0 
            var ItemsTotal = 12;
            var PriceTotal = 240;
            var tuple1 = (ItemsTotal: ItemsTotal, PriceTotal: PriceTotal);
            Console.WriteLine($"{tuple1.ItemsTotal} - {tuple1.PriceTotal}");

            // now in c# 7.1
            ItemsTotal = 8;
            PriceTotal = 145;
            var tuple2 = (ItemsTotal, PriceTotal);
            Console.WriteLine($"{tuple2.ItemsTotal} - {tuple2.PriceTotal}");

            // in return funciton the name of item2 or named second value
            ItemsTotal = 4;
            var tuple3 = (ItemsTotal, GetTotal());
            Console.WriteLine($"{tuple3.ItemsTotal} - {tuple3.Item2}");
            var tuple4 = (ItemsTotal, Total: GetTotal());
            Console.WriteLine($"{tuple4.ItemsTotal} - {tuple4.Total}");

            Console.ReadLine();
        }

        static int GetTotal()
        {
            return 83;
        }
    }
}
