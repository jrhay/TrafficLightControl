using CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightControlTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetControlStatus(TrafficLightControlState State)
        {
            trafficLightControl1.State = State;
            lblControlStatus.Text = trafficLightControl1.State.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGood.Checked)
                SetControlStatus(TrafficLightControlState.Good);
            else if (rdoBad.Checked)
                SetControlStatus(TrafficLightControlState.Bad);
            else if (rdoWarning.Checked)
                SetControlStatus(TrafficLightControlState.Warning);
            else
                SetControlStatus(TrafficLightControlState.None);
        }
    }
}
