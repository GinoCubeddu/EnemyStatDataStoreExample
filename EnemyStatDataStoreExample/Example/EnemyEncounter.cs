namespace EnemyStatDataStoreExample.Example
{
    public class EnemyEncounter
    {
        // How long the encounter laster
        public float EncounterTime { get; set; }

        // Haw many bullets were shot
        public float PlayerBuletsShot { get; set; }

        // How much damage the player took
        public float PlayerDamageTaken { get; set; }

        /// <summary>
        /// Constructor that sets values at 0
        /// </summary>
        public EnemyEncounter()
        {
            EncounterTime = 0f;
            PlayerBuletsShot = 0f;
            PlayerDamageTaken = 0f;
        }

        /// <summary>
        /// Constructor that allows you to set values
        /// </summary>
        /// <param name="encounterTime">How long the encounter took</param>
        /// <param name="bulletsShot">Haw many bullets were shot</param>
        /// <param name="playerDamageTaken">How much damage the player took</param>
        public EnemyEncounter(
            float encounterTime, float bulletsShot, float playerDamageTaken)
        {
            EncounterTime = encounterTime;
            PlayerBuletsShot = bulletsShot;
            PlayerDamageTaken = playerDamageTaken;
        }
    }
}
