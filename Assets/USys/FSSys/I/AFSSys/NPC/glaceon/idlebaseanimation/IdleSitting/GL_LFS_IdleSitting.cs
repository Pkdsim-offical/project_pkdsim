using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleSitting
{
	public class GL_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		
		public void GL_LFS_IdleSittingController()
		{
			Glaceon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Glaceon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}