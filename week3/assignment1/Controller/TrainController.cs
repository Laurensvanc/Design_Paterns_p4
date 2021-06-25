using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment1.Model;

namespace assignment1.Controller
{
    class TrainController : ITrainController
    {
        private ITrainJourney _trainJourney;
        public ITrainJourney TrainJourney { get { return _trainJourney; } }

        public TrainController(ITrainJourney trainJourney)
        {
            this._trainJourney = trainJourney;
        }

        public void NextStation()
        {
            _trainJourney.NextStation();
        }
    }
}
