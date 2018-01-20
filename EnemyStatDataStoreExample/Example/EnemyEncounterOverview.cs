using System.Collections.Generic;

namespace EnemyStatDataStoreExample.Example
{
    public class EnemyEncounterOverview
    {
        // Tells us how many times the player has encountered this enemy
        public int TotalEncounters { get; private set; }

        /* Tells us how long in total it has taken the player to deal with this
         * enemy type
         */
        public float TotalEncounterTime { get; private set; }

        // Tells us how many bullets in total the player has used in encounters
        public float TotalPlayerBuletsShot { get; private set; }

        /* Tells us how much damage in total this enemy type has done to the 
         *  player
         */
        public float TotalPlayerDamage { get; private set; }

        // Dictonary to hold all the encounters the player has had
        public IDictionary<string, EnemyEncounter> Encounters
        {
            get; private set;
        }

        // Constructor for class
        public EnemyEncounterOverview()
        {
            TotalEncounters = 0;
            TotalEncounterTime = 0f;
            TotalPlayerBuletsShot = 0f;
            TotalPlayerDamage = 0f;
            Encounters = new Dictionary<string, EnemyEncounter>();
        }

        /// <summary>
        /// Returns a specific encounter for the player if it exsists
        /// </summary>
        /// <param name="encounterID">The id of the encounter wanted</param>
        /// <returns></returns>
        public EnemyEncounter GetEncounter(string encounterID)
        {
            // Only return if encounter exsists else throw error
            try
            {
                return Encounters[encounterID];
            }
            catch (KeyNotFoundException)
            {
                throw new KeyNotFoundException(
                    "The EncounterID " + encounterID + " does not exsist."
                );
            }
        }

        /// <summary>
        /// Adds an encounter to the overall information
        /// </summary>
        /// <param name="encounter">The encounter object containing the
        /// information</param>
        public void AddEncounter(EnemyEncounter encounter)
        {
            TotalEncounters++;
            TotalEncounterTime += encounter.EncounterTime;
            TotalPlayerBuletsShot += encounter.PlayerBuletsShot;
            TotalPlayerDamage += encounter.PlayerDamageTaken;
            Encounters.Add(TotalEncounters.ToString(), encounter);
        }
    }
}
