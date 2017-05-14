using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public enum TrafficLightControlState
    {
        None,
        Good,
        Warning,
        Bad
    }

    public partial class TrafficLightControl : UserControl
    {
        private TrafficLightControlState _State;
        public TrafficLightControlState State
        {
            get { return _State; }
            set {
                _State = value;
                SetImageForState();
            }
        }

        private Bitmap LightImages = null;

        public TrafficLightControl()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            LightImages = global::TrafficLightControl.Properties.Resources.TrafficLightControlImages;
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (LightImages != null)
            {
                LightImages.Dispose();
                LightImages = null;
            }
            base.Dispose(disposing);
        }

        private void SetImageForState()
        {
            Rectangle imageRect;

            if (LightImages == null)
                return;

            switch (_State)
            {
                case TrafficLightControlState.Good:
                    imageRect = new Rectangle(323, 163, 260, 100);
                    break;
                case TrafficLightControlState.Bad:
                    imageRect = new Rectangle(323, 449, 260, 100);
                    break;
                case TrafficLightControlState.Warning:
                    imageRect = new Rectangle(323, 306, 260, 100);
                    break;
                default:
                    imageRect = new Rectangle(323, 20, 260, 100);
                    break;
            }

            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose();
            pictureBox1.Image = LightImages.Clone(imageRect, LightImages.PixelFormat);
        }
    }
}
