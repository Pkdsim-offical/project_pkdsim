using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleStanding
{
	public class PR_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public void PR_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Primarina_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Primarina_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}