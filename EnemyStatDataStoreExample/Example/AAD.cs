using System;
using System.IO;
using Newtonsoft.Json;

namespace EnemyStatDataStoreExample.Example
{
    public class AAD
    {
        private EnemyEncounters Encounters;

        public AAD()
        {
            Encounters = new EnemyEncounters();
        }

        public void ShowcaseEncounters()
        {
            // Add a new enemy type
            Encounters.AddNewEnemyType("archer");

            // Set up two encounters
            EnemyEncounter encounter1 = new EnemyEncounter(
                7f, 1f, 23f
            );
            EnemyEncounter encounter2 = new EnemyEncounter(
                3.5f, 2f, 46f
            );

            // Add the encounters to the object
            Encounters.GetEnemyEncounters("archer").AddEncounter(encounter1);
            Encounters.GetEnemyEncounters("archer").AddEncounter(encounter2);

            // Output the encounter time of to demo it has been created
            Console.WriteLine(
                Encounters.GetEnemyEncounters("archer").GetEncounter("1").
                    EncounterTime
            );
        }

        public void LoadDataFromFile(string fileName)
        {
            // Destroy the old encounters and recreate it.
            Encounters = null;
            Encounters = new EnemyEncounters();

            // Create the JSON reader
            JsonSerializer reader = new JsonSerializer();
            
            // Open the file
            var file = File.OpenText("Content/" + fileName);

            // Deserialize the json into the Encounters Object
            Encounters = (EnemyEncounters)reader.Deserialize(
                file, typeof(EnemyEncounters)
            );

            // Output the encounter time to demo it has read the file
            Console.WriteLine(
                Encounters.GetEnemyEncounters("archer").GetEncounter("1")
                .EncounterTime
            );

        }
    }
}
