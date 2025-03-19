using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.idlebaseanimation.IdleSitting
{
	public class HAT_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Hatterene_Animator;
		public void HAT_LFS_IdleSittingController()
		{
			Hatterene_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Hatterene_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}