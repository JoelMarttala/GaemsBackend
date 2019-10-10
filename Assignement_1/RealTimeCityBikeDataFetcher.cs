using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; 
using System.Linq;
namespace Assignement_1
{
    public class RealTimeCityBikeDataFetcher:ICityBikeDataFetcher
    {
        HttpClient client = new HttpClient();
		int bikeCount = 0;
        public async Task<int> GetBikeCountInStation(string stationName)
        {  
            bool stationFound = false;
            Exception NotFoundException = new Exception("Not found: " + stationName);
            if (stationName.Any(char.IsDigit))
                throw new ArgumentException("Station name should not contain numbers!");
            var outcome = await client.GetStringAsync("http://api.digitransit.fi/routing/v1/routers/hsl/bike_rental");
            BikeRentalStationList bikesList = JsonConvert.DeserializeObject<BikeRentalStationList>(outcome);
            for(int i = 0; i < bikesList.stations.Count; i++)
            {
                
                if(bikesList.stations[i].name == stationName)
                {
                    
                    bikeCount = bikesList.stations[i].bikesAvailable;
                    stationFound = true;
                }
            }
            if (stationFound)
                return bikeCount;
            else
                throw NotFoundException;
        
        
        }
    }
}