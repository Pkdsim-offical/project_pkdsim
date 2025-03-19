using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.idlebaseanimation.IdleStanding
{
	public class LO_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Lopunny_Animator;
		public void LO_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Lopunny_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lopunny_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}