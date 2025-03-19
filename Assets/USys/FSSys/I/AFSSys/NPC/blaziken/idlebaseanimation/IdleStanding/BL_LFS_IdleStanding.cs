using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleStanding
{
	public class BL_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Blaziken_Animator;
		public void BL_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Blaziken_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Blaziken_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}