using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation.IdleSitting
{
	public class BL_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Blaziken_Animator;
		public void BL_LFS_IdleSittingController()
		{
			Blaziken_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Blaziken_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}