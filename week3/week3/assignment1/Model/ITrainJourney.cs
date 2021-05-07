using assignment1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.Model
{
    public interface ITrainJourney
    {
        void AddObserver(IStationObserver observer);
        void NextStation();
        void RemoveObserver(IStationObserver observer);
    }
}
