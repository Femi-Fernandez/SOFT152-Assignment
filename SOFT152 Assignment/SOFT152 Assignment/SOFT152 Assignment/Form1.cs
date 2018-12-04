using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152_Assignment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Data.locations = new Location[0];
            SOFT152_Assignment.Location.SetupLocations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Location.SetupLocations();
        }
    }
}
