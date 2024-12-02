using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleStanding
{
	public class LE_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public void LE_LFS_IdleStandingController()
		{
			Leafeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Leafeon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}