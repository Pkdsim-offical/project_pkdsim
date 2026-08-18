using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.Modules.DIsableFallbackSys
{
	public class AFSysF_DIsableFallbackSys : MonoBehaviour 
	{
        private Animation animationComponent; // Legacy animation component for fallback
        private bool fallbackEnabled = false; // Tracks if the fallback system is active

		public void DisableFallbackSystem()
        {
            if (!fallbackEnabled)
            {
                Debug.LogWarning("Fallback system is already disabled.");
                return;
            }

            fallbackEnabled = false;

            // Remove the Animation component
            if (animationComponent != null)
            {
                Destroy(animationComponent);
                Debug.Log("Fallback system disabled.");
            }
		}
	}
}