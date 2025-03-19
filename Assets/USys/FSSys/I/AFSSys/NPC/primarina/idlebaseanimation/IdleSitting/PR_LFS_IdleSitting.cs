using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation.IdleSitting
{
	public class PR_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Primarina_Animator;
		public void PR_LFS_IdleSittingController()
		{
			Primarina_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Primarina_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}