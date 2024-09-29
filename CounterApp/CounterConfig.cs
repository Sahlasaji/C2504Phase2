using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example4
{
    static class CounterConfig
    {
        public static int Count { get; set; } = 0;

        public static ToolStripStatusLabel lblstatus { get; set; } = null;

        public static void ShowChild(Form parent, Form Child)
        {
            Child.MdiParent = parent;
            Child.Show();
            Child.Activate();
        }
    }
}
