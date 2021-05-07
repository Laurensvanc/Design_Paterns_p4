using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Model
{
    class TrainJourney : ITrainJourney
    {
        List<TrainStation> stations = new List<TrainStation>()
        {
            new TrainStation("Hoofddorp", "Spoor 3", new DateTime(2021, 05, 02, 10, 30, 00), new DateTime(2021, 05, 02, 10, 34, 00)),
            new TrainStation("Schiphol Airport", "Spoor 2", new DateTime(2021, 05, 02, 10, 39, 00), new DateTime(2021, 05, 02, 10, 41, 00)),
            new TrainStation("Amsterdam Lelylaan", "Spoor 2", new DateTime(2021, 05, 02, 10, 48, 00), new DateTime(2021, 05, 02, 10, 49, 00)),
            new TrainStation("Amsterdam Sloterdijk", "Spoor 12", new DateTime(2021, 05, 02, 10, 52, 00), new DateTime(2021, 05, 02, 10, 53, 00)),
            new TrainStation("Amsterdam Centraal", "Spoor 10b", new DateTime(2021, 05, 02, 10, 59, 00), new DateTime(2021, 05, 02, 11, 00, 00)),
            new TrainStation("Den Helder Centrum", "Spoor 2", new DateTime(2021, 05, 02, 11, 30, 00), new DateTime(2021, 05, 02, 11, 33, 00)),
            new TrainStation("Nijmegen", "Spoor 3", new DateTime(2021, 05, 02, 14, 15, 00), new DateTime(2021, 05, 02, 14, 17, 00)),
        };

        private List<IStationObserver> stationObserver;
        private int currentStation;

        public TrainJourney()
        {
            stationObserver = new List<IStationObserver>();
            currentStation = 0;
        }

        public void AddObserver(IStationObserver observer)
        {
            stationObserver.Add(observer);
            observer.Update(stations[currentStation]);
        }

        public void NextStation()
        {
            if (currentStation <= stations.Count)
            {
                currentStation++;

                foreach (IStationObserver observer in stationObserver)
                {
                    observer.Update(stations[currentStation]);
                }

                return;
            }

            Console.WriteLine("You've reached your destination");
        }

        public void RemoveObserver(IStationObserver observer)
        {
            stationObserver.Remove(observer);
        }
    }
}
