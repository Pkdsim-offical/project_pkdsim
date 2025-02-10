using UnityEngine;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Lopunny
{
    public class Lo_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Lo_FamilySceneTeleporter()
        {
        transform.position = teleportLocation.position;
        }
    }
}