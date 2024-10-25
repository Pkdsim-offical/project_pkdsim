
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Pr_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Pr_AniData
{
        public class Pr_AniData
        {
                private Pr_AniData_Transition Pr_AniData_Transitions;
                private Pr_AniData_Idle Pr_AniData_Idle;
                public void Load_Pr_AnimationData()
                {
                        Load_PrAniData_Idle();
                        Load_PrAniData_Transition();
                }
                public void Load_PrAniData_Idle() {
                        Pr_AniData_Idle.Pr_AniData_IdleST_I();
                        Pr_AniData_Idle.Pr_AniData_IdleSI_I();
                }
                public void Load_PrAniData_Transition() {
                        Pr_AniData_Transitions.Pr_AniData_SI2ST_I();
                        Pr_AniData_Transitions.Pr_AniData_ST2SI_I();
                }
        }
}