using UnityEngine;

namespace project_pkdsim.Assets.Models.USys.AFSSys.I
{
    public class AFSSys_I : MonoBehaviour
    {
        public Animator animator; // The primary Animator
        public string fallbackFolderPath; // Path to the folder containing .fbx files
        public string animationName; // Name of the animation clip to play as fallback

        private Animation animationComponent; // Legacy animation component for fallback
        private bool fallbackEnabled = false; // Tracks if the fallback system is active

        private void Start()
        {
            // Check if Animator is properly set up
            if (animator == null || !animator.runtimeAnimatorController)
            {
                Debug.LogWarning("Animator is missing or has no controller. Enabling fallback system.");
                EnableFallbackSystem();
            }
        }

        private void Update()
        {
            // Example: Monitor Animator and disable fallback if Animator is restored
            if (fallbackEnabled && animator != null && animator.runtimeAnimatorController)
            {
                Debug.Log("Animator restored. Disabling fallback system.");
                DisableFallbackSystem();
            }
        }

        private void EnableFallbackSystem()
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

        private void DisableFallbackSystem()
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