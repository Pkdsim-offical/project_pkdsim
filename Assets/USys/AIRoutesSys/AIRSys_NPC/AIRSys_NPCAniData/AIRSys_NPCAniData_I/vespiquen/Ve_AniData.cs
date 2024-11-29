using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ve_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Ve_AniData
{
public class Ve_AniData
    {
        private Ve_AniData_Transition Ve_AniData_Transitions;
        private Ve_AniData_Idle Ve_AniData_Idle;
        public void Load_Ve_AnimationData()
        {
            Load_VeAniData_Idle();
            Load_VeAniData_Transition();
        }
        public void Load_VeAniData_Idle() {
            Ve_AniData_Idle.Ve_AniData_IdleST();
            Ve_AniData_Idle.Ve_AniData_IdleSI();
        }
        public void Load_VeAniData_Transition() {
            Ve_AniData_Transitions.Ve_AniData_SI2ST_I();
            Ve_AniData_Transitions.Ve_AniData_ST2SI_I();
        }
    }
}