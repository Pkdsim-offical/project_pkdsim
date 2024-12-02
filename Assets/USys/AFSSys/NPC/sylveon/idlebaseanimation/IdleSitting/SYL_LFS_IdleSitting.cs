using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.idlebaseanimations.IdleSitting
{
	public class SYL_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public void SYL_IdleSittingController()
		{
			Sylveon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Sylveon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}