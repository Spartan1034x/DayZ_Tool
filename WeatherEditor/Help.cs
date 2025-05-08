using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherEditor
{
    // Handles all the help box pop ups
    public partial class WeatherMain
    {
        private void picHelpOvercastCurrent_Click(object sender, EventArgs e)
        {
            CurrentDefault();
        }

        private void picHelpOvercastLimits_Click(object sender, EventArgs e)
        {
            LimitsDefault();
        }

        private void picHelpOvercastTime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpOvercastChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpFogCurrent_Click(object sender, EventArgs e)
        {
            CurrentDefault();
        }

        private void picHelpFogLimits_Click(object sender, EventArgs e)
        {
           LimitsDefault();
        }

        private void picHelpFogTime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpFogChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpRainCurrent_Click(object sender, EventArgs e)
        {
            CurrentDefault();
        }

        private void picHelpRainLimits_Click(object sender, EventArgs e)
        {
            LimitsDefault();
        }

        private void picHelpRaintime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpRainChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpRainThreshold_Click(object sender, EventArgs e)
        {
            ThresholdDefault();
        }

        private void picHelpWindMagCurrent_Click(object sender, EventArgs e)
        {
            CurrentWind();
        }

        private void picHelpWindMagLimits_Click(object sender, EventArgs e)
        {
           LimitsWindMag();
        }

        private void picHelpWindMagTime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpWindMagChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpWindChangeCurrent_Click(object sender, EventArgs e)
        {
            CurrentWind();
        }

        private void picHelpWindChangeLimits_Click(object sender, EventArgs e)
        {
            LimitsWindDir();
        }

        private void picHelpWindChangeTime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpWindChangeChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpSnowfallCurrent_Click(object sender, EventArgs e)
        {
            CurrentDefault();
        }

        private void picHelpSnowfallLimits_Click(object sender, EventArgs e)
        {
            LimitsSnow();
        }

        private void picHelpSnowfallTime_Click(object sender, EventArgs e)
        {
            TimeDefault();
        }

        private void picHelpSnowfallChange_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }

        private void picHelpSnowfallThreshold_Click(object sender, EventArgs e)
        {
            ThresholdDefault();
        }


        // CURRENT
        // Help for the default current value (non wind) of the component
        private void CurrentDefault()
        {
            MessageBox.Show(" ACTUAL: The initial value e.g. For overcast/fog/rain/snow: 0.0 (none) to 1.0 (%100)" +
                "\n\n TIME: Time in seconds to reach actual value from previous condition" +
                "\n\n DURATION: How long this actual value should remain before transitioning to a new condition",
                "Current Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Help for wind 
        private void CurrentWind()
        {
            MessageBox.Show(" ACTUAL: The initial value e.g. For wind mag: 0.0 (none) to 8.0+ (m/s), for wind dir: -3.14 to 3.14 (radians)" +
                "\n\n TIME: Time in seconds to reach actual value from previous condition" +
                "\n\n DURATION: How long this actual value should remain before transitioning to a new condition",
                "Current Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // LIMITS
        // Help for limits default
        private void LimitsDefault()
        {
            MessageBox.Show("What is the Min and Max of the condition value e.g. Overcast 1.0 = 100% Overcast",
                "Limits Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Help for snow limits
        private void LimitsSnow()
        {
            MessageBox.Show("What is the Min and Max of the condition value e.g. Overcast 1.0 = 100% Overcast" +
                "\n\n\t** For Snow kept at Min: 0 , Max: 0 in vanilla **",
               "Limits Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Help for wind direction limits
        private void LimitsWindDir()
        {
            MessageBox.Show("What is the Min and Max direction of the wind in RADIANS, click \"Radians Help\" for conversion from degrees",
                "Limits Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Help for wind magnitude limits
        private void LimitsWindMag()
        {
            MessageBox.Show("What is the Min and Max magnitude of the wind speed in metres per second e.g. Min: 0.0 (no wind) Max: 20.0+ (20 m/s)",
                "Limits Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // TIME LIMITS
        // Help for time limits default
        private void TimeDefault()
        {
            MessageBox.Show("How long does it take the condition to change to another value between the Min and Max limits you have set (time in seconds)",
                "Time Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // CHANGE LIMITS
        // Help for change limits default
        private void ChangeDefault()
        {
            MessageBox.Show("Allowed value change size e.g. Overcast Min: 0.0 Max: 1.0, whenever the overcast value changes from one value to another it can change by up to %100" +
                "\n\nWind Mag change values are in m/s (0 - 20.0+)" +
                "\nWind Dir change values are in Radians (-3.14 - 3.14)",
                "Change Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // THRESHOLDS
        // Help for the threshold value of the component
        private void ThresholdDefault()
        {
            MessageBox.Show("MIN: Minimum value of overcast needed\n\n" +
                "MAX: Maximum value of overcast allowed\n\n" +
                "END: Time (in seconds) it takes for rain/snow to stop after conditions are no longer met\n\n" +
                "Example: Rain needs overcast between 0.5 and 1.0. If overcast drops below 0.5, rain ends within 120 seconds",
                "Threshold Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
