using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENG403_AlarmClock
{
    public partial class Form2 : Form
    {
        public Alarm alarm
        {
            get
            {
                return alarm;
            }
            set
            {
                alarm = value;
            }
        }
        
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void snoozeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
