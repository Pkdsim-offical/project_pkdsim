using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Frostlass
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