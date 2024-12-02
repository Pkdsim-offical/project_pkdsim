using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Dragapult
{
    public class Dr_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Dr_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}