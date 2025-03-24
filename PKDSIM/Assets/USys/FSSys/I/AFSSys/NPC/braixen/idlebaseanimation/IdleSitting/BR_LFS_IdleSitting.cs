using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation.IdleSitting
{
	public class BR_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Braixen_Animator;
		public void BR_LFS_IdleSittingController()
		{
			Braixen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Braixen_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}