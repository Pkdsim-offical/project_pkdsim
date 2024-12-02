using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleStanding
{
	public class FL_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public void FL_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}