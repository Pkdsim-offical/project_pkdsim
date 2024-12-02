using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.converteranimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.idlebaseanimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.Animator_I
{
	public class LFS_UmbreonFailSafe : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_LFS_AnimatorCoverterController Umbreon_LFS_AnimatorCCA;
		private Umbreon_LFS_AnimatorBaseMovementController Umbreon_LFS_AnimatorCMA;
		private Umbreon_LFS_AnimatorBaseIdleController Umbreon_LFS_AnimatorICA;

		public void LoadFailSafeUmbreon_AnimatorController()
		{
			
		}
		private void LoadFailSafeUmbreon_ConvertToAnimatorController()
		{

		}
		private void LoadFailSafeUmbreon_MovementAnimatorController()
		{
			
		}
		private void LoadFailSafeUmbreon_IdleAnimatorController()
		{
			
		}
	}
}