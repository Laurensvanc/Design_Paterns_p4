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
    public partial class ControlPanel : Form
    {
        

        public ControlPanel(ITrainJourney trainJourney)
        {
            InitializeComponent();

            TrainJourney = trainJourney;
            TrainJourney.AddObserver(this);
        }

        

        private void btn_NextStation_Click(object sender, EventArgs e)
        {

        }

        private void btn_NewDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
