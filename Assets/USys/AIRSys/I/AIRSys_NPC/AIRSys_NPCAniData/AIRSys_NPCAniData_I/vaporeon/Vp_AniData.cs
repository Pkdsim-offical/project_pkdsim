
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Vp_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Vp_AniData
{
public class Vp_AniData
    {
            private Vp_AniData_Transition Vp_AniData_Transitions;
            private Vp_AniData_Idle Vp_AniData_Idle;
            public void Load_Vp_AnimationData()
            {
                    Load_VpAniData_Idle();
                    Load_VpAniData_Transition();
            }
            public void Load_VpAniData_Idle() {
                Vp_AniData_Idle.Vp_AniData_IdleST_I();
                Vp_AniData_Idle.Vp_AniData_IdleSI_I();
            }
            public void Load_VpAniData_Transition() {
                Vp_AniData_Transitions.Vp_AniData_ST2SI_I();
                Vp_AniData_Transitions.Vp_AniData_SI2ST_I();

        }
    }
}