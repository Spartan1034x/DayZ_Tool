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
                Weather weather = (Weather)serializer.Deserialize(fileStream);
                
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
        }
    }
}
