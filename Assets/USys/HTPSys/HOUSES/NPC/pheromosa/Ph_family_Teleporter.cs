using UnityEngine;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Pheromosa
{
    public class Ph_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Ph_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}