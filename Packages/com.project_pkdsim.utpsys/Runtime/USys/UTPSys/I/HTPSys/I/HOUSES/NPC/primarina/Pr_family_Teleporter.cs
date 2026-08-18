using System.Collections;
using UnityEngine;

namespace project_pkdsim.USys.UTPSys.Modules.UHousesTeleporterSys.HOUSES.NPC.Primarina
{
    public class Pr_Family : MonoBehaviour
    {
        public Transform teleportLocation; // Assign the target location in the Inspector
        public void Pr_FamilySceneTeleporter()
        {
            transform.position = teleportLocation.position;
        }
    }
}