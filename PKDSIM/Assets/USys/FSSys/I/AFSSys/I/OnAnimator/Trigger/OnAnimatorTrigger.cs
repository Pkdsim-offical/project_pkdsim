using project_pkdsim.Assets.USys.AnimatorFailSafeSys.I.DIsableFallbackSys;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AnimatorFailSafeSys.I.OnAnimator.Trigger
{
    public class AFSSysF_OnAnimatorTrigger : MonoBehaviour 
    {
        private AFSysF_DIsableFallbackSys DIsableFallbackSys;
        private bool OnAnimatorSetter_enabled = false;
        private Animator PrimaryAnimator;
        public void OnAnimatorTrigger()
        {
            string triggerName = PrimaryAnimator.GetCurrentAnimatorStateInfo(0).fullPathHash.ToString();
            if (OnAnimatorSetter_enabled)
            {
                Debug.Log($"Trigger: {triggerName} received. Disabling fallback system.");
                DIsableFallbackSys.DisableFallbackSystem();
            }
        }
    }
}