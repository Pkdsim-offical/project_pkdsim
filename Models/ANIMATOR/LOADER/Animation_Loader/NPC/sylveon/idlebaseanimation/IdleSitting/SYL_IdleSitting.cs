using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation.IdleSitting
{
	public class SYL_IdleSitting : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYL_IdleSittingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}