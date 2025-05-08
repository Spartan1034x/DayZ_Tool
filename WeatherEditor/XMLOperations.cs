using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace WeatherEditor
{
    internal static class XMLOperations
    {

        /// <summary>
        ///     Saves the weather object to an XML file.
        /// </summary>
        /// <param name="filePath">
        ///     String file path to .XML
        /// </param>
        /// <returns>
        ///     WeatherObject
        /// </returns>
        public static Weather? LoadWeatherFromXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Weather));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                Weather? weather = null;
                try
                {                     // Check if the file is empty
                    if (fileStream.Length == 0)
                    {
                        Console.WriteLine("File is empty.");
                        return null;
                    }

                    weather = (Weather)serializer.Deserialize(fileStream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening file: {ex.Message}");
                    return null;
                }
                
                return weather;
            }
        }


        /// <summary>
        ///       Saves the weather object to an XML file.
        /// </summary>
        /// <param name="filePath"> String </param>
        /// <param name="weather"> Weather object </param>
        /// <returns> true if success </returns>
        public static bool SaveWeatherToXML(string filePath, Weather weather)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Weather));
            
            var xmlWriterSettings = new System.Xml.XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  "
            };

            var xmlSerializerNamespaces = new System.Xml.Serialization.XmlSerializerNamespaces();
            xmlSerializerNamespaces.Add(string.Empty, string.Empty);

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (System.Xml.XmlWriter xmlWriter = System.Xml.XmlWriter.Create(fileStream, xmlWriterSettings))
                    {
                        serializer.Serialize(xmlWriter, weather, xmlSerializerNamespaces);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving XML: {ex.Message}");
                return false;
            }
        } // End SaveWeatherToXML



        // Vanilla weather object with default values
        internal readonly static Weather VanillaWeather = new Weather
        {
            Reset = 0,
            Enable = 0,
            Overcast = new Overcast
            {
                Current = new Current { Actual = 0.45, Time = 120, Duration = 240 },
                Limits = new Limits { Min = 0.0, Max = 1.0 },
                Timelimits = new Timelimits { Min = 600, Max = 900 },
                Changelimits = new Changelimits { Min = 0.0, Max = 1.0 }
            },
            Fog = new Fog
            {
                Current = new Current { Actual = 0.05, Time = 120, Duration = 240 },
                Limits = new Limits { Min = 0.02, Max = 0.08 },
                Timelimits = new Timelimits { Min = 900, Max = 900 },
                Changelimits = new Changelimits { Min = 0.0, Max = 1.0 }
            },
            Rain = new Rain
            {
                Current = new Current { Actual = 0.0, Time = 60, Duration = 120 },
                Limits = new Limits { Min = 0.0, Max = 1.0 },
                Timelimits = new Timelimits { Min = 60, Max = 120 },
                Changelimits = new Changelimits { Min = 0.0, Max = 1.0 },
                Thresholds = new Thresholds { Min = 0.6, Max = 1.0, End = 60 }
            },
            WindMagnitude = new WindMagnitude
            {
                Current = new Current { Actual = 8.0, Time = 120, Duration = 240 },
                Limits = new Limits { Min = 0.0, Max = 20.0 },
                Timelimits = new Timelimits { Min = 120, Max = 240 },
                Changelimits = new Changelimits { Min = 0.0, Max = 20.0 }
            },
            WindDirection = new WindDirection
            {
                Current = new Current { Actual = 0.0, Time = 120, Duration = 240 },
                Limits = new Limits { Min = -3.14, Max = 3.14 },
                Timelimits = new Timelimits { Min = 60, Max = 120 },
                Changelimits = new Changelimits { Min = -1.0, Max = 1.0 }
            },
            Snowfall = new Snowfall
            {
                Current = new Current { Actual = 0.0, Time = 0, Duration = 32768 },
                Limits = new Limits { Min = 0.0, Max = 0.0 },
                Timelimits = new Timelimits { Min = 300, Max = 3600 },
                Changelimits = new Changelimits { Min = 0.0, Max = 0.0 },
                Thresholds = new Thresholds { Min = 1.0, Max = 1.0, End = 120 }
            },
            Storm = new Storm
            {
                Density = 1.0,
                Threshold = 0.9,
                Timeout = 45
            }
        }; // End VanillaWeather obj

    }
}
