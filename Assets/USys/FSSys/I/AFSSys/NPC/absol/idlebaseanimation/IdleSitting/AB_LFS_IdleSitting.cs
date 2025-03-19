using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.idlebaseanimation.IdleSitting
{
	public class AB_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Absol_Animator;
		public void AB_LFS_IdleSittingController()
		{
			Absol_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Absol_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}