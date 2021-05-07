using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    class TrainController : ITrainController
    {
        private ITrainJourney trainjourney;

        public TrainController(ITrainJourney trainJourney)
        {
            this.trainjourney = trainJourney;
        }

        public ITrainJourney trainJourney { get { return trainJourney; } }

        public void NextStation()
        {
            trainjourney.NextStation();
        }
    }
}
