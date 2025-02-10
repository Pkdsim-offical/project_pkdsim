
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ph_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Ph_AniData
{
        public class Ph_AniData
        {
                private Ph_AniData_Transition Ph_AniData_Transitions;
                private Ph_AniData_Idle Ph_AniData_Idle;
                public void Load_Ph_AnimationData()
                {
                        Load_PhAniData_Idle();
                        Load_PhAniData_Transition();
                }
                public void Load_PhAniData_Idle() {
                        Ph_AniData_Idle.Ph_AniData_IdleST_I();
                        Ph_AniData_Idle.Ph_AniData_IdleSI_I();
                }
                public void Load_PhAniData_Transition() {
                        Ph_AniData_Transitions.Ph_AniData_SI2ST_I();
                        Ph_AniData_Transitions.Ph_AniData_ST2SI_I();
                }
        }
}