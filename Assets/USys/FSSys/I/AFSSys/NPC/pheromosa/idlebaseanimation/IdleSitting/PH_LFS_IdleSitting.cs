using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.idlebaseanimation.IdleSitting
{
	public class PH_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Pheromosa_Animator;
		public void PH_LFS_IdleSittingController()
		{
			Pheromosa_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Pheromosa_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}