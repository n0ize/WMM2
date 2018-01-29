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
        StartGUI startGUI;

        public Highscore(StartGUI startGUI)
        {
            InitializeComponent();
            this.startGUI = startGUI;    
        }

        private void buttonZurück_Click(object sender, EventArgs e)
        {
            startGUI.Visible = true;
            this.Close();
        }
    }
}
