using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation.IdleStanding
{
	public class GARD_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Gardevoir_Animator;
		public void GARD_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Gardevoir_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Gardevoir_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}