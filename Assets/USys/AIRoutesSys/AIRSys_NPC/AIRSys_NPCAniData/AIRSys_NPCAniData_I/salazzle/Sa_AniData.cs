using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sa_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Sa_AniData
{
    public class Sa_AniData
    {
        private Sa_AniData_Transition Sa_AniData_Transitions;
        private Sa_AniData_Idle Sa_AniData_Idle;
        public void Load_Sa_AnimationData()
        {
                Load_SaAniData_Idle();
                Load_SaAniData_Transition();
        }
        public void Load_SaAniData_Idle() {
                Sa_AniData_Idle.Sa_AniData_IdleST_I();
                Sa_AniData_Idle.Sa_AniData_IdleSI_I();
        }
        public void Load_SaAniData_Transition() {
                Sa_AniData_Transitions.Sa_AniData_SI2ST_I();
                Sa_AniData_Transitions.Sa_AniData_ST2SI_I();
        }
    }
}