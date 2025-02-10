using UnityEngine;
using UnityEngine.SceneManagement;
namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Absol
{
    public class Ab_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector

        public void Ab_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    void Update()
    {
            transform.position = teleportLocation.position;
    }
    }
}