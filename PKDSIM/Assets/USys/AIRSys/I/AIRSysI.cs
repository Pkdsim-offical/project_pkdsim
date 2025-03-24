using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_I
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