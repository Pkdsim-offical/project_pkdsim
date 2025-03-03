using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation.IdleStanding
{
	public class AB_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Absol_Animator;
		public void AB_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}