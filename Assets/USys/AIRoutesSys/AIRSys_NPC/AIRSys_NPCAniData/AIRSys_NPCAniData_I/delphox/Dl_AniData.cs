using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Dl_AniData.AniData_Transitions;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Dl_AniData
{
    public class Dl_AniData
    {
        private Dl_AniData_Transition Dl_AniData_Transitions;
        private Dl_AniData_Idle Dl_AniData_Idle;
        public void  Load_Dl_AnimationData()
        {
                Load_DlAniData_Idle();
                Load_DlAniData_Transition();
        }
        public void Load_DlAniData_Idle() {
            Dl_AniData_Idle.Dl_AniData_IdleST_I();
            Dl_AniData_Idle.Dl_AniData_IdleSI_I();
        }
        public void Load_DlAniData_Transition() {
            Dl_AniData_Transitions.Dl_AniData_SI2ST_I();
            Dl_AniData_Transitions.Dl_AniData_ST2SI_I();
        }
    }
}
