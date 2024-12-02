using Unity.Entities.UniversalDelegates;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.idlebaseanimations.IdleStanding
{
	public class VP_LFS_IdleStanding : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VP_LFS_IdleStandingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Standing");         // Start in the Idle animation state
		}
	}
}