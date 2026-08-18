using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Salazzle
{
    public class Sa_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Sa_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}