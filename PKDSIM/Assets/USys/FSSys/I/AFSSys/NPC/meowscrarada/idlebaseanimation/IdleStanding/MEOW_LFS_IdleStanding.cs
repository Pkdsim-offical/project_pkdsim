using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.idlebaseanimation.IdleStanding
{
	public class MEOW_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Meowscarada_Animator;
		public void MEOW_LFS_IdleStandingController()
		{
			// Assign the idle animation clip
			Meowscarada_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Meowscarada_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}