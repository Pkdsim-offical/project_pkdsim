using UnityEngine;
using UnityEngine.SceneManagement;
namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.FlareonAVaporeonAJolteon
{
    public class FlVpJo_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void FlVpJo_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}