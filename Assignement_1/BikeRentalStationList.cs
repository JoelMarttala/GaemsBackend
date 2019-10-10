using System;
using System.Collections.Generic;
namespace Assignement_1
{
    public class BikeRentalStationList
    {
     public List<BikeRentalStationList> stations { get; set; }
    public string id { get; set; }
    public string name { get; set; }
    public double x { get; set; }
    public double y { get; set; }
    public int bikesAvailable { get; set; }
    public int spacesAvailable { get; set; }
    public bool allowDropoff { get; set; }
    public bool isFloatingBike { get; set; }
    public bool isCarStation { get; set; }
    public string state { get; set; }
    public List<string> networks { get; set; }
    public bool realTimeData { get; set; }
    
    }
}