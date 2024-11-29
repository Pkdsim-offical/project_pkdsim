using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Idle;
using project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.AIRSys_NPCAniData_I.Um_AniData.AniData_Transitions;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AIRoutesSys.AIRSys_NPCAniData.Um_AniData
{
public class Um_AniData : MonoBehaviour
    {
        private Um_AniData_Transition Um_AniData_Transitions;
        private Um_AniData_Idle Um_AniData_Idle;
                public void Load_Um_AnimationData()
            {
                    Load_UmAniData_Idle();
                    Load_UmAniData_Transition();
            }
        public void Load_UmAniData_Idle() {
            Um_AniData_Idle.Um_AniData_IdleST_I();
            Um_AniData_Idle.Um_AniData_IdleSI_I();
        }
        public void Load_UmAniData_Transition() {
            Um_AniData_Transitions.Um_AniData_SI2ST_I();
            Um_AniData_Transitions.Um_AniData_ST2SI_I();
        }
    }
}