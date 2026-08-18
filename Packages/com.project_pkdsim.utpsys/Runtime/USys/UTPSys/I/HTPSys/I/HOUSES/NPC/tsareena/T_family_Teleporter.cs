using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Tsareena
{
    public class T_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void T_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}