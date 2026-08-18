using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Lunala
{
    public class Luna_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Luna_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}