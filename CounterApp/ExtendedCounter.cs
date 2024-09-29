using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    public partial class ExtendedCounter : Form
    {
        public ExtendedCounter()
        {
            InitializeComponent();
        }

        private void ExtendedCounter_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count += (int)txtStep.Value;

            lblCounter.Text = CounterConfig.Count.ToString();
            CounterConfig.lblstatus.Text = "Plus";
        }

        private void btnMinuse_Click(object sender, EventArgs e)
        {
            CounterConfig.Count -= (int)txtStep.Value;

            lblCounter.Text = CounterConfig.Count.ToString();
            CounterConfig.lblstatus.Text = "Minus";
        }

        private void ExtendedCounter_Enter(object sender, EventArgs e)
        {
            lblCounter.Text = CounterConfig.Count.ToString();
        }
    }
}
