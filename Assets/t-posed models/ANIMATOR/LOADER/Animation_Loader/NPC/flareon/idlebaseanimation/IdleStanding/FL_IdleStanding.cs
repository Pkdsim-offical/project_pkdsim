using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.idlebaseanimation.IdleStanding
{
	public class FL_IdleStanding : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public void FL_IdleStandingController()
		{
			// Assign the idle animation clip
			Flareon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Flareon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}