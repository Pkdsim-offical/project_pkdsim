using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation.IdleSitting
{
	public class Z_LFS_IdleSitting : MonoBehaviour 
	{
		private Animator Zoroark_Animator;
		public void Z_LFS_IdleSittingController()
		{
			Zoroark_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Zoroark_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}