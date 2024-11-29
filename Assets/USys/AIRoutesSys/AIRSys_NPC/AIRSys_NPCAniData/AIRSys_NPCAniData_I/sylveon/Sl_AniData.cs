
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Sl_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Sl_AniData
{
    public class Sl_AniData
    {
                private Sl_AniData_Transition Sl_AniData_Transitions;
                private Sl_AniData_Idle Sl_AniData_Idle;
                public void Load_Sl_AnimationData()
                {
                        Load_SlAniData_Idle();
                        Load_SlAniData_Transition();
                }
                public void Load_SlAniData_Idle() {
                        Sl_AniData_Idle.Sl_AniData_IdleST_I();
                        Sl_AniData_Idle.Sl_AniData_IdleSI_I();
                }
                public void Load_SlAniData_Transition() {
                        Sl_AniData_Transitions.Sl_AniData_SI2ST_I();
                        Sl_AniData_Transitions.Sl_AniData_ST2SI_I();
                }
    }
}