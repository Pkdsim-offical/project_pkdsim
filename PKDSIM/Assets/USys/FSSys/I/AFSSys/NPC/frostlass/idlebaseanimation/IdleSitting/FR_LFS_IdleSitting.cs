using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.idlebaseanimation.IdleSitting
{
	public class FR_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Frostlass_Animator;
		public void FR_LFS_IdleSittingController()
		{
			Frostlass_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Frostlass_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}