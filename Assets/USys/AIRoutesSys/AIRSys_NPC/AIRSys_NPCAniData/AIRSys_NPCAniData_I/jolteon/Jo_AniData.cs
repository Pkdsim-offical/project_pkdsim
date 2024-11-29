using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Jo_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Jo_AniData
{
    public class Jo_AniData
    {
                private Jo_AniData_Transition Jo_AniData_Transitions;
                private Jo_AniData_Idle Jo_AniData_Idle;
                public void Load_Jo_AnimationData()
                {
                        Load_JoAniData_Idle();
                        Load_JoAniData_Transition();
                }
                public void Load_JoAniData_Idle() {
                        Jo_AniData_Idle.Jo_AniData_IdleST_I();
                        Jo_AniData_Idle.Jo_AniData_IdleSI_I();
                }
                public void Load_JoAniData_Transition() {
                        Jo_AniData_Transitions.Jo_AniData_SI2ST_I();
                        Jo_AniData_Transitions.Jo_AniData_ST2SI_I();
                }
    }
}