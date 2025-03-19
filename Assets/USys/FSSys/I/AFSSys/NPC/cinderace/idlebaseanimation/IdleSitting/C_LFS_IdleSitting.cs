using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.idlebaseanimation.IdleSitting
{
	public class C_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Cinderace_Animator;
		public void C_LFS_IdleSittingController()
		{
			Cinderace_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Cinderace_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}