using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleStanding
{
	public class BR_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Braixen_Animator;
		public void BR_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Braixen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Braixen_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}