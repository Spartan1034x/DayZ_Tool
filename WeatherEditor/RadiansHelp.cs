using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherEditor
{
    public partial class RadiansHelp : Form
    {
        public RadiansHelp()
        {
            InitializeComponent();
        }


        // Close Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Degrees changed
        private void nudDegrees_ValueChanged(object sender, EventArgs e)
        {
            // When degrees is changed call to radians and set value of radians nud to result
            nudRadians.Value = (decimal)ToRadians((float)nudDegrees.Value);
        }

        // Radians changed
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // When radians is changed call to degrees and set value of degrees nud to result
            nudDegrees.Value = (decimal)ToDegrees((float)nudRadians.Value);
        }

        // Convert degrees to radians
        private float ToRadians(float degrees)
        {
            // Convert to radians
            float radians = degrees * (float)Math.PI / 180f;
            return radians;
        }


        // Convert radians to degrees
        private float ToDegrees(float radians)
        {
            // Convert to degrees
            float degrees = radians * 180f / (float)Math.PI;
            return degrees;
        }

    }
}
