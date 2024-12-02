using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.idlebaseanimation.IdleStanding
{
	public class NOI_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Noivern_Animator;
		public void NOI_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Noivern_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Noivern_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}