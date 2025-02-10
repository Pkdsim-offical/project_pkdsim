
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Ts_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.T_AniData
{
    public class Ts_AniData
    {
        private Ts_AniData_Transition Ts_AniData_Transitions;
        private Ts_AniData_Idle Ts_AniData_Idle;
        public void Load_Ts_AnimationData()
        {
                Load_TsAniData_Idle();
                Load_TsAniData_Transition();
        }
        public void Load_TsAniData_Idle() {
                Ts_AniData_Idle.Ts_AniData_IdleST_I();
                Ts_AniData_Idle.Ts_AniData_IdleSI_I();
        }
        public void Load_TsAniData_Transition() {
                Ts_AniData_Transitions.Ts_AniData_SI2ST_I();
                Ts_AniData_Transitions.Ts_AniData_ST2SI_I();
        }
    }
}