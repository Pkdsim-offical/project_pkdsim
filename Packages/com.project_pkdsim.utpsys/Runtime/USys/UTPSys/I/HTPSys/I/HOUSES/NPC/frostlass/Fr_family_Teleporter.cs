using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Frostlass
{
    public class Fr_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Fr_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}