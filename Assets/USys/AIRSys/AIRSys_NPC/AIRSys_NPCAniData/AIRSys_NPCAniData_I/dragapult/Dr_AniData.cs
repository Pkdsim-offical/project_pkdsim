using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dr_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Dr_AniData
{
    public class Dr_AniData : MonoBehaviour
    {
        private Dr_AniData_Transition Dr_AniData_Transitions;
        private Dr_AniData_Idle Dr_AniData_Idle;
        public void  Load_Dr_AnimationData()
        {
                Load_DrAniData_Idle();
                Load_DrAniData_Transition();
        }
        public void Load_DrAniData_Idle() {
            Dr_AniData_Idle.Dr_AniData_IdleST_I();
            Dr_AniData_Idle.Dr_AniData_IdleSI_I();
        }
        public void Load_DrAniData_Transition() {
            Dr_AniData_Transitions.Dr_AniData_SI2ST_I();
            Dr_AniData_Transitions.Dr_AniData_ST2SI_I();
        }
    }
}