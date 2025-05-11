using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace GlobalsEditor
{
    internal static class XMLOperations
    {

        /// <summary>
        ///   Loads the global variables from an XML file.
        /// </summary>
        /// <param name="filePath"> File path string </param>
        /// <returns> Variable object </returns>
        internal static Variables? LoadVariablesFromXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Variables));

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                Variables? Variables = null;
                try
                {                     // Check if the file is empty
                    if (fileStream.Length == 0)
                    {
                        Console.WriteLine("File is empty.");
                        return null;
                    }

                    Variables = (Variables)serializer.Deserialize(fileStream);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening file: {ex.Message}");
                    return null;
                }

                return Variables;
            }
        } // End LoadVariablesFromXML



        /// <summary>
        ///     Save Global object to xml path sent
        /// </summary>
        /// <param name="filePath"> String: file path</param>
        /// <param name="Variables"> Variable: obj</param>
        /// <returns> true if success</returns>
        internal static bool SaveGlobalsToXML(string filePath, Variables Variables)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Variables));

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
                        serializer.Serialize(xmlWriter, Variables, xmlSerializerNamespaces);
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



        /// <summary>
        ///  Creates vanilla global object 
        /// </summary>
        /// <returns> Vanilla Object </returns>
        internal static Variables CreateVanillaGlobalsObject()
        {
            // Create the Variables object and populate the list of Var
            Variables variables = new Variables
            {
                Var = new List<Var>
                {
                    new Var { Name = "AnimalMaxCount", Type = 0, Value = 200 },
                    new Var { Name = "CleanupAvoidance", Type = 0, Value = 100 },
                    new Var { Name = "CleanupLifetimeDeadAnimal", Type = 0, Value = 1200 },
                    new Var { Name = "CleanupLifetimeDeadInfected", Type = 0, Value = 330 },
                    new Var { Name = "CleanupLifetimeDeadPlayer", Type = 0, Value = 3600 },
                    new Var { Name = "CleanupLifetimeDefault", Type = 0, Value = 45 },
                    new Var { Name = "CleanupLifetimeLimit", Type = 0, Value = 50 },
                    new Var { Name = "CleanupLifetimeRuined", Type = 0, Value = 330 },
                    new Var { Name = "FlagRefreshFrequency", Type = 0, Value = 432000 },
                    new Var { Name = "FlagRefreshMaxDuration", Type = 0, Value = 3456000 },
                    new Var { Name = "FoodDecay", Type = 0, Value = 1 },
                    new Var { Name = "IdleModeCountdown", Type = 0, Value = 60 },
                    new Var { Name = "IdleModeStartup", Type = 0, Value = 1 },
                    new Var { Name = "InitialSpawn", Type = 0, Value = 100 },
                    new Var { Name = "LootDamageMax", Type = 1, Value = 82 },
                    new Var { Name = "LootDamageMin", Type = 1, Value = 0 },
                    new Var { Name = "LootProxyPlacement", Type = 0, Value = 1 },
                    new Var { Name = "LootSpawnAvoidance", Type = 0, Value = 100 },
                    new Var { Name = "RespawnAttempt", Type = 0, Value = 2 },
                    new Var { Name = "RespawnLimit", Type = 0, Value = 20 },
                    new Var { Name = "RespawnTypes", Type = 0, Value = 12 },
                    new Var { Name = "RestartSpawn", Type = 0, Value = 0 },
                    new Var { Name = "SpawnInitial", Type = 0, Value = 1200 },
                    new Var { Name = "TimeHopping", Type = 0, Value = 60 },
                    new Var { Name = "TimeLogin", Type = 0, Value = 15 },
                    new Var { Name = "TimeLogout", Type = 0, Value = 15 },
                    new Var { Name = "TimePenalty", Type = 0, Value = 20 },
                    new Var { Name = "WorldWetTempUpdate", Type = 0, Value = 1 },
                    new Var { Name = "ZombieMaxCount", Type = 0, Value = 1000 },
                    new Var { Name = "ZoneSpawnDist", Type = 0, Value = 300 }
                }
            };

            return variables;
        } // End CreateVanillaObject


    }
}
