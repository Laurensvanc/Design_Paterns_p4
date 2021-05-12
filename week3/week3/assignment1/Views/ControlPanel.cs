using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using assignment1.Controller;
using assignment1.Model;

namespace assignment1.Views
{
    public partial class ControlPanel : Form
    {
        private ITrainController Panelcontroller;

        public ControlPanel(ITrainController controller)
        {
            InitializeComponent();

            Panelcontroller = controller;
        }

        private void btn_NextStation_Click(object sender, EventArgs e)
        {
            Panelcontroller.NextStation();
        }

        private void btn_NewDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay newDisplay = new TrainDisplay(Panelcontroller.TrainJourney);
            newDisplay.Show();
        }
    }
}
