using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void Progress_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                this.progressBar1.Increment(1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
