using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.idlebaseanimation.IdleStanding
{
	public class ES_IdleStanding : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public void ES_IdleStandingController()
		{
			Espeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Espeon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}

	}
}