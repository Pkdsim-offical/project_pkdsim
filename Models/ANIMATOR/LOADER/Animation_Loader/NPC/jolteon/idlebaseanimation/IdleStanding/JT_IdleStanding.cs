using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleStanding
{
	public class JT_IdleStanding : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public void JT_IdleStandingController()
		{
			Jolteon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Jolteon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}