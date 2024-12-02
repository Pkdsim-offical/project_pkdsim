using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleStanding
{
	public class UM_IdleStanding : MonoBehaviour 
	{
		public Animator Umbreon_Animator;

		public void UM_IdleStandingController()
		{
			Umbreon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Umbreon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}