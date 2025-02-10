using UnityEngine;

namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Noivern
{
    public class No_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void No_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}