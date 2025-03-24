using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation.IdleSitting
{
	public class BE_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Beedrill_Animator;
		public void BE_LFS_IdleSittingController()
		{
			Beedrill_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Beedrill_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}