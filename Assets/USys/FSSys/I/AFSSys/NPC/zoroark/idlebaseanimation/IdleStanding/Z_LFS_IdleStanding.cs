using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleStanding
{
	public class Z_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public void Z_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}