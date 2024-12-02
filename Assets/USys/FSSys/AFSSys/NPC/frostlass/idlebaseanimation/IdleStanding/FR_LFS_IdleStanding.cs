using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleStanding
{
	public class FR_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Frostlass_Animator;
		public void FR_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Frostlass_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Frostlass_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}