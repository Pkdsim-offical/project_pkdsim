
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Cl_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Ci_AniData
{
        public class Ci_AniData : MonoBehaviour
        {
            private Cl_AniData_Transition Cl_AniData_Transitions;
            private Cl_AniData_Idle Cl_AniData_Idle;
            public void Load_Ci_AnimationData()
            {
                    Load_ClAniData_Idle();
                    Load_ClAniData_Transition();
            }
            public void Load_ClAniData_Idle() {
                Cl_AniData_Idle.Cl_AniData_IdleST_I();
                Cl_AniData_Idle.Cl_AniData_IdleSI_I();
            }
            public void Load_ClAniData_Transition() {
                Cl_AniData_Transitions.Cl_AniData_SI2ST_I();
                Cl_AniData_Transitions.Cl_AniData_ST2SI_I();
        }
    }
}