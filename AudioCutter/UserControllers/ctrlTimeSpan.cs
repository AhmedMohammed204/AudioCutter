using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioCutter
{
    public partial class ctrlTimeSpan : UserControl
    {
        public TimeSpan TimeSpan
        {
            get
            {
                return new TimeSpan((int)nudHours.Value, (int)nudMinutes.Value, (int)nudSeconds.Value);
            }
            set
            {
                nudHours.Value = value.Hours;
                nudMinutes.Value = value.Minutes;
                nudSeconds.Value = value.Seconds;
            }
        }
        public ctrlTimeSpan()
        {
            InitializeComponent();
        }

    }
}
