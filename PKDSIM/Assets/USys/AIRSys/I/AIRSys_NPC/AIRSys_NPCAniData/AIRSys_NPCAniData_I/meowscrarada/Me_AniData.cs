

using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Me_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Me_AniData
{
        public class Me_AniData
        {
                private Me_AniData_Transition Me_AniData_Transitions;
                private Me_AniData_Idle Me_AniData_Idle;
                public void Load_Me_AnimationData()
                {
                        Load_MeAniData_Idle();
                        Load_MeAniData_Transition();
                }
                public void Load_MeAniData_Idle() {
                        Me_AniData_Idle.Me_AniData_IdleST_I();
                        Me_AniData_Idle.Me_AniData_IdleSI_I();
                }
                public void Load_MeAniData_Transition() {
                        Me_AniData_Transitions.Me_AniData_SI2ST_I();
                        Me_AniData_Transitions.Me_AniData_ST2SI_I();
                }
        }
}