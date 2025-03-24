using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.idlebaseanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.Animator_I
{
	public class LFS_UmbreonFailSafe : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_LFS_AnimatorCoverterController LFSUmbreon_AnimatorCCA;
		private Umbreon_LFS_AnimatorBaseMovementController LFSUmbreon_AnimatorCMA;
		private Umbreon_LFS_AnimatorBaseIdleController LFSUmbreon_AnimatorICA;

		public void LoadFailSafeUmbreon_AnimatorController()
		{
			LoadFailSafeUmbreon_ConvertToAnimatorController();
			LoadFailSafeUmbreon_IdleAnimatorController();
			LoadFailSafeUmbreon_MovementAnimatorController();
		}
		private void LoadFailSafeUmbreon_ConvertToAnimatorController()
		{
			LFSUmbreon_AnimatorCCA.UM_LFS_ConverterToAnimatorController();
		}
		private void LoadFailSafeUmbreon_MovementAnimatorController()
		{
			LFSUmbreon_AnimatorCMA.UM_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeUmbreon_IdleAnimatorController()
		{
			LFSUmbreon_AnimatorICA.UM_LFS_IdleAnimatorController();
		}
	}
}