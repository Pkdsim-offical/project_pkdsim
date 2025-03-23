using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation.IdleStanding
{
	public class DR_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Dragapult_Animator;
		public void DR_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Dragapult_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Dragapult_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}