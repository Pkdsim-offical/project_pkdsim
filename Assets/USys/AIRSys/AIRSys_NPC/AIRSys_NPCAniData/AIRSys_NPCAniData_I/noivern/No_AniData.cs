using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.No_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.No_AniData
{
        public class No_AniData
        {
                private No_AniData_Transition No_AniData_Transitions;
                private No_AniData_Idle No_AniData_Idle;
                public void Load_No_AnimationData()
                {
                        Load_NoAniData_Idle();
                        Load_NoAniData_Transition();
                }
                public void Load_NoAniData_Idle() {
                        No_AniData_Idle.No_AniData_IdleST_I();
                        No_AniData_Idle.No_AniData_IdleSI_I();
                }
                public void Load_NoAniData_Transition() {
                        No_AniData_Transitions.No_AniData_SI2ST_I();
                        No_AniData_Transitions.No_AniData_ST2SI_I();
                }
        }
}