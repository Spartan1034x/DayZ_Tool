using System.Xml.Serialization;

namespace WeatherEditor
{
    public partial class WeatherMain : Form
    {
        //              VARIABLES
        //
        private Weather? loadedWeather; // Weather object to hold weather data

        private string? loadedFilePath; // File path of the loaded XML file



        //              CONSTRUCTOR
        //
        //
        public WeatherMain()
        {
            InitializeComponent();
        }



        //              FORM LOAD
        //
        //
        private void WeatherMain_Load(object sender, EventArgs e)
        {
            CreateToolTips(); // Create tooltips for buttons
            LoopThroughPictureBoxes(this); // Format the help buttons
        }



        //              FORMAT HELP BUTTONS
        //
        // Sets the cursor for each help button to hand pointer
        void LoopThroughPictureBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Cursor = Cursors.Hand; // Set the cursor to hand pointer
                }
                else if (control.HasChildren)
                {
                    // Recursively search child controls
                    LoopThroughPictureBoxes(control);
                }
            }
        }




        //             CREATE TOOL TIPS
        //
        // Creates tooltips for the buttons on the form
        private void CreateToolTips()
        {
            // Create tooltips for the buttons
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(chkReset, "Resets the weather on server wipe");
            toolTip.SetToolTip(chkEnable, "Enables reading from cfgweather.xml, leave enabled");
            toolTip.SetToolTip(btnLoad, "Load a weather XML file");
            toolTip.SetToolTip(btnSave, "Save the weather data to an XML file");
        } // End of CreateToolTips



        //              LOAD BUTTON CLICK
        //
        // Creates open file dialog to select a weather XML file, then calls LoadWeatherFromXML to create a Weather object
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Weather XML file";
            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = ofd.FileName;
                loadedWeather = XMLOperations.LoadWeatherFromXML(loadedFilePath);

                if (loadedWeather == null)
                {
                    MessageBox.Show("Error Loading .xml File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtLoadedFile.Text = loadedFilePath;

                PopulateInputs(); // Populate the inputs with the loaded weather data
            }

            ofd.Dispose(); // Dispose of the OpenFileDialog
        } // End of btnLoad_Click




        //              POPULATE INPUTS
        //
        //
        // Populates the inputs with the local weather object that is populated with the loaded XML data
        private void PopulateInputs()
        {
            if (loadedWeather == null)
                return;

            // Populate check boxes
            chkReset.Checked = (loadedWeather.Reset == 1);
            chkEnable.Checked = (loadedWeather.Enable == 1);

            // Populate the Overcast inputs
            nudOvercastCurrentActual.Value = (decimal)loadedWeather.Overcast.Current.Actual;
            nudOvercastCurrentTime.Value = (decimal)loadedWeather.Overcast.Current.Time;
            nudOvercastCurrentDuration.Value = (decimal)loadedWeather.Overcast.Current.Duration;

            nudOvercastLimitsMin.Value = (decimal)loadedWeather.Overcast.Limits.Min;
            nudOvercastLimitsMax.Value = (decimal)loadedWeather.Overcast.Limits.Max;

            nudOvercastTimeMin.Value = (decimal)loadedWeather.Overcast.Timelimits.Min;
            nudOvercastTimeMax.Value = (decimal)loadedWeather.Overcast.Timelimits.Max;

            nudOvercastChangeMin.Value = (decimal)loadedWeather.Overcast.Changelimits.Min;
            nudOvercastChangeMax.Value = (decimal)loadedWeather.Overcast.Changelimits.Max;

            // Populate Fog inputs
            nudFogCurrentActual.Value = (decimal)loadedWeather.Fog.Current.Actual;
            nudFogCurrentTime.Value = (decimal)loadedWeather.Fog.Current.Time;
            nudFogCurrentDuration.Value = (decimal)loadedWeather.Fog.Current.Duration;

            nudFogLimitsMin.Value = (decimal)loadedWeather.Fog.Limits.Min;
            nudFogLimitsMax.Value = (decimal)loadedWeather.Fog.Limits.Max;

            nudFogTimeMin.Value = (decimal)loadedWeather.Fog.Timelimits.Min;
            nudFogTimeMax.Value = (decimal)loadedWeather.Fog.Timelimits.Max;

            nudFogChangeMin.Value = (decimal)loadedWeather.Fog.Changelimits.Min;
            nudFogChangeMax.Value = (decimal)loadedWeather.Fog.Changelimits.Max;

            // Populate Rain inputs
            nudRainCurrentActual.Value = (decimal)loadedWeather.Rain.Current.Actual;
            nudRainCurentTime.Value = (decimal)loadedWeather.Rain.Current.Time;
            nudRainCurrentDuration.Value = (decimal)loadedWeather.Rain.Current.Duration;

            nudRainLimitsMin.Value = (decimal)loadedWeather.Rain.Limits.Min;
            nudRainLimitsMax.Value = (decimal)loadedWeather.Rain.Limits.Max;

            nudRainTimeMin.Value = (decimal)loadedWeather.Rain.Timelimits.Min;
            nudRainTimeMax.Value = (decimal)loadedWeather.Rain.Timelimits.Max;

            nudRainChangeMin.Value = (decimal)loadedWeather.Rain.Changelimits.Min;
            nudRainChangeMax.Value = (decimal)loadedWeather.Rain.Changelimits.Max;

            nudRainThresholdEnd.Value = (decimal)loadedWeather.Rain.Thresholds.End;
            nudRainThresholdMin.Value = (decimal)loadedWeather.Rain.Thresholds.Min;
            nudRainThresholdMax.Value = (decimal)loadedWeather.Rain.Thresholds.Max;

            // Populate Wind Magnitude inputs
            nudWindMagCurrentActual.Value = (decimal)loadedWeather.WindMagnitude.Current.Actual;
            nudWindMagCurrentTime.Value = (decimal)loadedWeather.WindMagnitude.Current.Time;
            nudWindMagCurrentDuration.Value = (decimal)loadedWeather.WindMagnitude.Current.Duration;

            nudWindMagLimitMin.Value = (decimal)loadedWeather.WindMagnitude.Limits.Min;
            nudWindMagLimitMax.Value = (decimal)loadedWeather.WindMagnitude.Limits.Max;

            nudWindMagTimeMin.Value = (decimal)loadedWeather.WindMagnitude.Timelimits.Min;
            nudWindMagTimeMax.Value = (decimal)loadedWeather.WindMagnitude.Timelimits.Max;

            nudWindMagChangeMin.Value = (decimal)loadedWeather.WindMagnitude.Changelimits.Min;
            nudWindMagChangeMax.Value = (decimal)loadedWeather.WindMagnitude.Changelimits.Max;

            // Populate Wind Direction inputs
            nudWindDirCurrentActual.Value = (decimal)loadedWeather.WindDirection.Current.Actual;
            nudWindDirCurrentTime.Value = (decimal)loadedWeather.WindDirection.Current.Time;
            nudWindDirCurrentDuration.Value = (decimal)loadedWeather.WindDirection.Current.Duration;

            nudWindDirLimitsMin.Value = (decimal)loadedWeather.WindDirection.Limits.Min;
            nudWindDirLimitsMax.Value = (decimal)loadedWeather.WindDirection.Limits.Max;

            nudWindDirTimeMin.Value = (decimal)loadedWeather.WindDirection.Timelimits.Min;
            nudWindDirTimeMax.Value = (decimal)loadedWeather.WindDirection.Timelimits.Max;

            nudWindDirChangeMin.Value = (decimal)loadedWeather.WindDirection.Changelimits.Min;
            nudWindDirChangeMax.Value = (decimal)loadedWeather.WindDirection.Changelimits.Max;

            // Populate Snowfall inputs
            nudSnowCurrentActual.Value = (decimal)loadedWeather.Snowfall.Current.Actual;
            nudSnowCurrentTime.Value = (decimal)loadedWeather.Snowfall.Current.Time;
            nudSnowCurrentDuration.Value = (decimal)loadedWeather.Snowfall.Current.Duration;

            nudSnowLimitsMin.Value = (decimal)loadedWeather.Snowfall.Limits.Min;
            nudSnowLimitsMax.Value = (decimal)loadedWeather.Snowfall.Limits.Max;

            nudSnowTimeMin.Value = (decimal)loadedWeather.Snowfall.Timelimits.Min;
            nudSnowTimeMax.Value = (decimal)loadedWeather.Snowfall.Timelimits.Max;

            nudSnowChangeMin.Value = (decimal)loadedWeather.Snowfall.Changelimits.Min;
            nudSnowChangeMax.Value = (decimal)loadedWeather.Snowfall.Changelimits.Max;

            nudSnowThresholdEnd.Value = (decimal)loadedWeather.Snowfall.Thresholds.End;
            nudSnowThresholdMin.Value = (decimal)loadedWeather.Snowfall.Thresholds.Min;
            nudSnowThresholdMax.Value = (decimal)loadedWeather.Snowfall.Thresholds.Max;

            // Populate Storm inputs
            nudStormDensity.Value = (decimal)loadedWeather.Storm.Density;
            nudStormThreshold.Value = (decimal)loadedWeather.Storm.Threshold;
            nudStormTimeout.Value = (decimal)loadedWeather.Storm.Timeout;



        } // End of PopulateInputs



        //              CHK ENABLE CHECKED CHANGED
        //
        // Checks if the checkbox is checked, if not, it prompts the user to confirm disabling the weather
        private void chkEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEnable.Checked)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to disable the weather?", "Disable Weather", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                chkEnable.Checked = (result == DialogResult.Yes) ? false : true;
            }
        } // End of chkEnable_CheckedChanged




        //              SAVE BUTTON CLICK
        //
        // Saves the weather data to an XML file
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save Weather XML file";
                sfd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                sfd.InitialDirectory = loadedFilePath == null ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : loadedFilePath;
                sfd.FileName = "cfgweather.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    loadedFilePath = sfd.FileName;

                    Weather weather = new Weather
                    {
                        Reset = chkReset.Checked ? 1 : 0,
                        Enable = chkEnable.Checked ? 1 : 0,

                        Overcast = new Overcast
                        {
                            Current = new Current
                            {
                                Actual = (double)nudOvercastCurrentActual.Value,
                                Time = (int)nudOvercastCurrentTime.Value,
                                Duration = (int)nudOvercastCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudOvercastLimitsMin.Value,
                                Max = (double)nudOvercastLimitsMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudOvercastTimeMin.Value,
                                Max = (int)nudOvercastTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudOvercastChangeMin.Value,
                                Max = (double)nudOvercastChangeMax.Value
                            }
                        },

                        Fog = new Fog
                        {
                            Current = new Current
                            {
                                Actual = (double)nudFogCurrentActual.Value,
                                Time = (int)nudFogCurrentTime.Value,
                                Duration = (int)nudFogCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudFogLimitsMin.Value,
                                Max = (double)nudFogLimitsMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudFogTimeMin.Value,
                                Max = (int)nudFogTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudFogChangeMin.Value,
                                Max = (double)nudFogChangeMax.Value
                            }
                        },

                        Rain = new Rain
                        {
                            Current = new Current
                            {
                                Actual = (double)nudRainCurrentActual.Value,
                                Time = (int)nudRainCurentTime.Value,
                                Duration = (int)nudRainCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudRainLimitsMin.Value,
                                Max = (double)nudRainLimitsMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudRainTimeMin.Value,
                                Max = (int)nudRainTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudRainChangeMin.Value,
                                Max = (double)nudRainChangeMax.Value
                            },
                            Thresholds = new Thresholds
                            {
                                End = (int)nudRainThresholdEnd.Value,
                                Min = (double)nudRainThresholdMin.Value,
                                Max = (double)nudRainThresholdMax.Value
                            }
                        },

                        WindMagnitude = new WindMagnitude
                        {
                            Current = new Current
                            {
                                Actual = (double)nudWindMagCurrentActual.Value,
                                Time = (int)nudWindMagCurrentTime.Value,
                                Duration = (int)nudWindMagCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudWindMagLimitMin.Value,
                                Max = (double)nudWindMagLimitMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudWindMagTimeMin.Value,
                                Max = (int)nudWindMagTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudWindMagChangeMin.Value,
                                Max = (double)nudWindMagChangeMax.Value
                            }
                        },

                        WindDirection = new WindDirection
                        {
                            Current = new Current
                            {
                                Actual = (double)nudWindDirCurrentActual.Value,
                                Time = (int)nudWindDirCurrentTime.Value,
                                Duration = (int)nudWindDirCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudWindDirLimitsMin.Value,
                                Max = (double)nudWindDirLimitsMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudWindDirTimeMin.Value,
                                Max = (int)nudWindDirTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudWindDirChangeMin.Value,
                                Max = (double)nudWindDirChangeMax.Value
                            }
                        },

                        Snowfall = new Snowfall
                        {
                            Current = new Current
                            {
                                Actual = (double)nudSnowCurrentActual.Value,
                                Time = (int)nudSnowCurrentTime.Value,
                                Duration = (int)nudSnowCurrentDuration.Value
                            },
                            Limits = new Limits
                            {
                                Min = (double)nudSnowLimitsMin.Value,
                                Max = (double)nudSnowLimitsMax.Value
                            },
                            Timelimits = new Timelimits
                            {
                                Min = (int)nudSnowTimeMin.Value,
                                Max = (int)nudSnowTimeMax.Value
                            },
                            Changelimits = new Changelimits
                            {
                                Min = (double)nudSnowChangeMin.Value,
                                Max = (double)nudSnowChangeMax.Value
                            },
                            Thresholds = new Thresholds
                            {
                                End = (int)nudSnowThresholdEnd.Value,
                                Min = (double)nudSnowThresholdMin.Value,
                                Max = (double)nudSnowThresholdMax.Value
                            }
                        },

                        Storm = new Storm
                        {
                            Density = (double)nudStormDensity.Value,
                            Threshold = (double)nudStormThreshold.Value,
                            Timeout = (int)nudStormTimeout.Value
                        }
                    };

                    // Save to XML
                    bool res = XMLOperations.SaveWeatherToXML(loadedFilePath, weather);
                    if (!res)
                    {
                        MessageBox.Show("Error saving weather file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                        MessageBox.Show("Weather file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
