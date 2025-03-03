using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation.IdleStanding
{
	public class GARC_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Garchomp_Animator;
		public void GARC_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Garchomp_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Garchomp_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}