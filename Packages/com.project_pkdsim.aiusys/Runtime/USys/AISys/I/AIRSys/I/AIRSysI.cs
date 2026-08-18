using project_pkdsim.USys.AISys.Modules.AIRoutesSys.AIRSys_NPCAniData;
using UnityEngine;

namespace project_pkdsim.USys.AISys.Modules.AIRoutesSys.Modules
{
    public class AIRSysI: MonoBehaviour
    {
        private AIRSys_NPCAnimation_Data Npc_AniData;
        public void NPC_AniData(string AniData)
        {
            Npc_AniData.AIRSys_NPCAniData("AniData");
        }
    }
}