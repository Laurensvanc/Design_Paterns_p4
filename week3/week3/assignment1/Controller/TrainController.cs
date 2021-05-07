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
        private ITrainJourney trainjourney;

        public TrainController(ITrainJourney trainJourney)
        {
            this.trainjourney = trainJourney;
        }

        public ITrainJourney TrainJourney { get { return TrainJourney; } }

        public void NextStation()
        {
            trainjourney.NextStation();
        }
    }
}
