using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Delphox
{
    public class Dl_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Dl_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}