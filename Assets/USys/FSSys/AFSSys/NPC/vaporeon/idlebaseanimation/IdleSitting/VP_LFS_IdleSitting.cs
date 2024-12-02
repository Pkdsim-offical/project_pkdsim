using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleSitting
{
	public class VP_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VP_LFS_IdleSittingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}