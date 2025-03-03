using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.idlebaseanimation.IdleStanding
{
	public class LUNA_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Lunala_Animator;
		public void LUNA_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Lunala_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lunala_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}