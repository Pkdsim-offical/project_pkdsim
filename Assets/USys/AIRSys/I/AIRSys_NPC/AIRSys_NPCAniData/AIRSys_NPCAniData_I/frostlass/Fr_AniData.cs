using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Fr_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Fr_AniData
{
        public class Fr_AniData
        {
                private Fr_AniData_Transition Fr_AniData_Transitions;
                private Fr_AniData_Idle Fr_AniData_Idle;
                public void  Load_Fr_AnimationData()
                {
                        Load_FrAniData_Idle();
                        Load_FrAniData_Transition();
                }
                public void Load_FrAniData_Idle()
                {
                        Fr_AniData_Idle.Fr_AniData_IdleST_I();
                        Fr_AniData_Idle.Fr_AniData_IdleSI_I();
                }
                public void Load_FrAniData_Transition()
                {
                        Fr_AniData_Transitions.Fr_AniData_SI2ST_I();
                        Fr_AniData_Transitions.Fr_AniData_ST2SI_I();
                }
        }
}
