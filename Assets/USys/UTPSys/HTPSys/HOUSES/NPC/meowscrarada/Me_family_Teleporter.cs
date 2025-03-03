using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.Meowscarada
{
    
    public class Me_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Me_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}