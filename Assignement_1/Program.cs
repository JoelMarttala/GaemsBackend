using System;
using System.Threading.Tasks;


namespace Assignement_1
{

    class Program
    {
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("Give Station name: ");
            string Stationname = Console.ReadLine();
            RealTimeCityBikeDataFetcher r = new RealTimeCityBikeDataFetcher();
            
           var res =  await r.GetBikeCountInStation(Stationname);
            Console.WriteLine(res);
            
        }
    }
}
