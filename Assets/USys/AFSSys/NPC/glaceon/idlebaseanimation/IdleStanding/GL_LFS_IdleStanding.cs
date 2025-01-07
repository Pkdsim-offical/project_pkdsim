using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Glaceon.idlebaseanimation.IdleStanding
{
	public class GL_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public void GL_LFS_IdleStandingController()
		{
			Glaceon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Glaceon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}