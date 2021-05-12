using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment1.Model;

namespace assignment1.Views
{
    public partial class TrainDisplay : Form, IStationObserver
    {
        ITrainJourney TrainJourney;

        public TrainDisplay(ITrainJourney trainJourney)
        {
            InitializeComponent();

            TrainJourney = trainJourney;
            TrainJourney.AddObserver(this);
        }

        public void Update(TrainStation currentStation)
        {
            lbl_CurrentStation.Text = currentStation.name;
            lbl_CurrentTrack.Text = currentStation.arrivalTrack;
        }
    }
}
