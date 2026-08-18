using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation.IdleStanding
{
	public class PL_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public void PL_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}