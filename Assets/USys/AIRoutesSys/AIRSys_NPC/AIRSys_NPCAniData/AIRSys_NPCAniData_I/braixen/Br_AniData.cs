
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Br_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Br_AniData {
    public class Br_AniData : MonoBehaviour
    {
        private Br_AniData_Transition Br_AniData_Transitions;
        private Br_AniData_Idle Br_AniData_Idle;
        public void Load_Br_AnimationData()
        {
                Load_BrAniData_Idle();
                Load_BrAniData_Transition();
        }
        public void Load_BrAniData_Idle() {
            Br_AniData_Idle.Br_AniData_IdleST_I();
            Br_AniData_Idle.Br_AniData_IdleSI_I();
        }
        public void Load_BrAniData_Transition() {
            Br_AniData_Transitions.Br_AniData_SI2ST_I();
            Br_AniData_Transitions.Br_AniData_ST2SI_I();
        }
    }
}