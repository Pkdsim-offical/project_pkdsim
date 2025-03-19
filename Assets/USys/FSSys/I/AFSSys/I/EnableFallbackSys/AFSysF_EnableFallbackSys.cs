using UnityEngine;

namespace project_pkdsim.Assets.USys.AnimatorFailSafeSys.I.EnableFallbackSys
{
	public class AFSysF_EnableFallbackSys : MonoBehaviour 
	{
        private string fallbackFolderPath; // Path to the folder containing .fbx files
		private string animationName; // Name of the animation clip to play as fallback

        private Animation animationComponent; // Legacy animation component for fallback
        private bool fallbackEnabled; // Tracks if the fallback system is active

		public void EnableFallbackSystem()
        {
            if (fallbackEnabled)
            {
                Debug.LogWarning("Fallback system is already enabled.");
                return;
            }

            fallbackEnabled = true;

            // Add an Animation component to the GameObject
            animationComponent = gameObject.AddComponent<Animation>();

            // Load the fallback animation clip from the specified folder
            string path = $"{fallbackFolderPath}/{animationName}.fbx";
            AnimationClip fallbackClip = Resources.Load<AnimationClip>(path);

            if (fallbackClip != null)
            {
                // Add the clip to the Animation component and play it
                animationComponent.AddClip(fallbackClip, animationName);
                animationComponent.Play(animationName);
                Debug.Log($"Playing fallback animation: {animationName}");
            }
            else
            {
                Debug.LogError($"Fallback animation not found at path: {path}. Fallback system remains active.");
            }
        }
	}
}