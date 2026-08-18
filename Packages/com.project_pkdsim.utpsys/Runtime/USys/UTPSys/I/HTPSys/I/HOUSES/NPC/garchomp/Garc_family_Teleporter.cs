using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Garchomp
{
    public class Garc_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Garc_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}