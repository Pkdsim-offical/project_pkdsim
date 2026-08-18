using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Blaziken
{
    public class Bl_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Bl_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}