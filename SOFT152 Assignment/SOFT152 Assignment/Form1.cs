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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Data.locations = new Location[0];
            SOFT152_Assignment.Location.setupLocationArray();

            for (int i = 0; i < 11; i++)
            {
                combLocation.Items.Add(Data.locations[i].getLocationName());
            }
            
        }

        private void combLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = combLocation.SelectedIndex;

            int numyears = Data.locations[pos].getnumyears();

            for (int i = 0; i < numyears; i++)
            {
                combYear.Items.Add(Data.locations[pos].getyearinfo()[i].getYearDesc());
            }
        }
    }
}
