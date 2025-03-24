using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimation.IdleSitting
{
	public class UM_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Umbreon_Animator;
		public void UM_LFS_IdleSittingController()
		{
			Umbreon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Umbreon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}