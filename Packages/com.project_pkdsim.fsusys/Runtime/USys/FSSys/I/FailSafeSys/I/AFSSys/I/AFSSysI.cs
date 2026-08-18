using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.OnAnimator.Trigger;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.DIsableFallbackSys;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.EnableFallbackSys;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.OnAnimator.Restore;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules
{
    public class AFSSysI : MonoBehaviour
    {
        private AFSysF_DIsableFallbackSys DIsabler_FallbackSys;
        private AFSysF_EnableFallbackSys Enabler_FallbackSystem;
        private AFSSysF_OnAnimatorRestore OnAnimatorRestore;
        private AFSSysF_OnAnimatorTrigger OnAnimatorTrigger;

        public void AFSSys_I() 
        {
            LoadEnabler_FallbackSystem();
            LoadDisabler_FallbackSystem();
            LoadOA_OnAnimatorRestore();
            LoadOA_OnAnimatorTrigger();
        }
        private void LoadOA_OnAnimatorRestore()
        {
            OnAnimatorRestore.OnAnimatorRestore();
        }
        private void LoadOA_OnAnimatorTrigger()
        {
            OnAnimatorTrigger.OnAnimatorTrigger();
        }
        private void LoadEnabler_FallbackSystem()
        {
            Enabler_FallbackSystem.EnableFallbackSystem();
        }

        private void LoadDisabler_FallbackSystem()
        {
            DIsabler_FallbackSys.DisableFallbackSystem();
        }
    }
}