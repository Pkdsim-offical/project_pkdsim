using System.Collections;
using UnityEngine;

namespace project_pkdsim.Assets.USys.UTPSys.UHousesTeleporterSys.HOUSES.NPC.LeafeonAGlaceon
{
    public class LeGl_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void LeGl_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}