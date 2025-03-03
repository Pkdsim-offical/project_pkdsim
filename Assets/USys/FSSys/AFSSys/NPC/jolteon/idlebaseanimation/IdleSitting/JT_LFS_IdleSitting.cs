using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation.IdleSitting
{
	public class JT_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public void JT_IdleSittingController()
		{
			Jolteon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Jolteon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}