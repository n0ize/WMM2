using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWWM
{
    public partial class Highscore : Form
    {
        StartGUI sg;

        public Highscore(StartGUI sg)
        {
            InitializeComponent();
            this.sg = sg;    
        }

        private void buttonZurück_Click(object sender, EventArgs e)
        {
            sg.Visible = true;
            this.Close();
        }
    }
}
