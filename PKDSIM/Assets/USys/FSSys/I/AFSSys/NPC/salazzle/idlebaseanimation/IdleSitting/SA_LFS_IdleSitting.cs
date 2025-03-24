using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation.IdleSitting
{
	public class SA_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Salazzle_Animator;
		public void SA_LFS_IdleSittingController()
		{
			Salazzle_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Salazzle_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}