using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation.IdleStanding
{
	public class DL_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public void DL_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Delphox_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Delphox_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}