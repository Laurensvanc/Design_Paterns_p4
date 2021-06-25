using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment1.Model;

namespace assignment1.Controller
{
    public interface ITrainController
    {
        ITrainJourney TrainJourney { get; }
        void NextStation();
    }
}
