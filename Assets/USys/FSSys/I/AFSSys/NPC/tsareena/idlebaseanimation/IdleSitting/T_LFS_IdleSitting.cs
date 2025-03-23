using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation.IdleSitting
{
	public class T_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Tsareena_Animator;
		public void T_LFS_IdleSittingController()
		{
			Tsareena_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Tsareena_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}