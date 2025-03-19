using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleStanding
{
	public class T_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public void T_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Tsareena_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Tsareena_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}