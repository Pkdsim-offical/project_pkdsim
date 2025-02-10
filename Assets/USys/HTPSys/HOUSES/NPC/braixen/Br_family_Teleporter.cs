using UnityEngine;
using UnityEngine.SceneManagement;
namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Braixen
{
    public class Br_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Br_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}