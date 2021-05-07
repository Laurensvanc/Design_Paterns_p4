using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TrainStation
    {
        public string name { get; set; }
        public string arrivalTrack { get; set; }
        public DateTime arrivalTime { get; set; }
        public DateTime departureTime { get; set; }

        public TrainStation(string name, string arrivalTrack, DateTime arrivalTime, DateTime departureTime)
        {
            this.name = name;
            this.arrivalTrack = arrivalTrack;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
        }
    }
}
