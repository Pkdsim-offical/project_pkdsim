using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleStanding
{
	public class BE_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Beedrill_Animator;
		public void BE_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Beedrill_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Beedrill_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}