using UnityEngine;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Gardevoir
{
    public class Gard_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Gard_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}