using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Hatterene
{
    public class H_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void H_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}