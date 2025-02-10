
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Le_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Le_AniData{
    public class Le_AniData
    {
                private Le_AniData_Transition Le_AniData_Transitions;
                private Le_AniData_Idle Le_AniData_Idle;
                public void Load_Le_AnimationData()
                {
                        Load_LeAniData_Idle();
                        Load_LeAniData_Transition();
                }
                public void Load_LeAniData_Idle() {
                        Le_AniData_Idle.Le_AniData_IdleST_I();
                        Le_AniData_Idle.Le_AniData_IdleSI_I();
                }
                public void Load_LeAniData_Transition() {
                        Le_AniData_Transitions.Le_AniData_SI2ST_I();
                        Le_AniData_Transitions.Le_AniData_ST2SI_I();
                }
    }
}
