using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Es_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Es_AniData
{
    public class Es_AniData : MonoBehaviour
    {
        private Es_AniData_Transition Es_AniData_Transitions;
        private Es_AniData_Idle Es_AniData_Idle;
        public void  Load_Es_AnimationData()
        {
            Load_EsAniData_Idle();
            Load_EsAniData_Transition();
        }
        public void Load_EsAniData_Idle() {
            Es_AniData_Idle.Es_AniData_IdleST_I();
            Es_AniData_Idle.Es_AniData_IdleSI_I();
        }
        public void Load_EsAniData_Transition() {
            Es_AniData_Transitions.Es_AniData_SI2ST_I();
            Es_AniData_Transitions.Es_AniData_ST2SI_I();
        }
    }
}