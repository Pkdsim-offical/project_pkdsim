using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Vespiquen
{
    public class Ve_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Ve_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}