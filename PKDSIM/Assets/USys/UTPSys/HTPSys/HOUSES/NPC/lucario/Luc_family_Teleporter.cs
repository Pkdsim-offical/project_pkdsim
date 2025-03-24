using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Lucario
{
    public class Luca_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Luca_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}