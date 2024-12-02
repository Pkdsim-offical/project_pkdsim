using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.idlebaseanimation.IdleStanding
{
	public class LUCA_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Lucario_Animator;
		public void LUCA_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Lucario_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Lucario_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}