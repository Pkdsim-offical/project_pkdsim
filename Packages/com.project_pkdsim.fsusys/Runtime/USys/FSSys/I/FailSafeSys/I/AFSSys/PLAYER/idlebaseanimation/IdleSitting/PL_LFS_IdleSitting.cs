using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation.IdleSitting
{
	public class PL_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Absol_Animator;
		public void PL_LFS_IdleSittingController()
		{
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}