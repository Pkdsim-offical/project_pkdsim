using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Beedrill
{
    public class Be_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Be_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}
