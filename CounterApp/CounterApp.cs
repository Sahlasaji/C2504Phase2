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
    public partial class CounterApp : Form
    {
        public CounterApp()
        {
            InitializeComponent();
            CounterConfig.lblstatus = lblStatus;
        }
        private Counter frmCounter= new Counter();
        private ExtendedCounter frmExtendedCounter= new ExtendedCounter();

        private void mnuSimpleContainer_Click(object sender, EventArgs e)
        {

            CounterConfig.ShowChild(this,frmCounter);


        }

        private void mnuExtendedCounter_Click(object sender, EventArgs e)
        {
            CounterConfig.ShowChild(this, frmExtendedCounter);
        }
    }
}
