using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Zoroark
{
    public class Z_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Z_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}