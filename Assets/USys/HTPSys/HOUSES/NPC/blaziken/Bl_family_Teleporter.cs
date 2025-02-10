using UnityEngine;
using UnityEngine.SceneManagement;
namespace project_pkdsim.Assets.USys.HTPSys.HOUSES.NPC.Blaziken
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