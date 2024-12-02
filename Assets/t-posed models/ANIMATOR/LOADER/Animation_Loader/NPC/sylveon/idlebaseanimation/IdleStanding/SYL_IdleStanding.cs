using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation.IdleStanding
{
	public class SYL_IdleStanding : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYL_IdleStandingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}