using System;
using System.Collections.Generic;

namespace EnemyStatDataStoreExample.Example
{
    public class EnemyEncounters
    {
        // Dictonary to hold all the encounters that have happened
        public IDictionary<string, EnemyEncounterOverview> Encounters
        {
            get; private set;
        }

        /// <summary>
        /// Basic constructor
        /// </summary>
        public EnemyEncounters()
        {
            Encounters = new Dictionary<string, EnemyEncounterOverview>();
        }

        /// <summary>
        /// Add a new enemy type to the encounters
        /// </summary>
        /// <param name="name">The name of the enemy</param>
        public void AddNewEnemyType(string name)
        {
            // Throw error if the enemy already exsists
            if (Encounters.ContainsKey(name))
                throw new Exception(
                    "An enemy with the name " + name + " already exsists"
               );
            Encounters.Add(name, new EnemyEncounterOverview());
        }

        /// <summary>
        /// Gets the enemy encounters for one type of enemy
        /// </summary>
        /// <param name="name">Name of the enenmy</param>
        /// <returns>an EnemyEncounterOverview object containing the
        /// encounters</returns>
        public EnemyEncounterOverview GetEnemyEncounters(string name)
        {
            // Throw error if enemy does not exsist
            try
            {
                return Encounters[name];
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException(
                    "The enemy of type " + name + " does not exsist."
                );
            }
        }
    }
}
