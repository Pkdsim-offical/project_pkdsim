using UnityEngine;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Sylveon
{
    public class SYL_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void SYL_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}