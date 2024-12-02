using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.FlareonAVaporeonAJolteon
{
    public class FlVpJo_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void FlVpJo_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}