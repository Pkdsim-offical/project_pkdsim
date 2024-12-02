using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleStanding
{
	public class C_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Cinderace_Animator;
		public void C_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Cinderace_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Cinderace_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}