using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation.IdleStanding
{
	public class SA_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Salazzle_Animator;
		public void SA_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Salazzle_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Salazzle_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}