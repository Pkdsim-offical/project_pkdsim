using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo.IdleToWalk
{
	public class VE_LFS_IdleToWalk : MonoBehaviour 
	{
		private Animator Vespiquen_Animator;
		public void VE_LFS_IdleToWalkController()
		{
			Vespiquen_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vespiquen_Animator.Play("Idle_ToWalk");         // Start in the Idle animation state
		}
	}
}