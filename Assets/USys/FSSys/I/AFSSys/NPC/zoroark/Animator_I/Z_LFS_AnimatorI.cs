using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.Animator_I
{
	public class LFS_ZoroarkFailSafe : MonoBehaviour 
	{
		public Animator Zoroark_Animator;
		public RuntimeAnimatorController someController;

		private Zoroark_LFS_CoverterAnimatorController LFSZoroark_AnimatorCCA;
		private Zoroark_LFS_AnimatorBaseMovementController LFSZoroark_AnimatorCMA;
		private Zoroark_LFS_IdleAnimatorController LFSZoroark_AnimatorICA;


		public void LoadFailSafeZoroark_AnimatorController()
		{
			LoadFailSafeZoroark_ConvertToAnimatorController();
			LoadFailSafeZoroark_MovementAnimatorController();
			LoadFailSafeZoroark_IdleAnimatorController();
		}
		private void LoadFailSafeZoroark_ConvertToAnimatorController()
		{
			LFSZoroark_AnimatorCCA.Z_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeZoroark_MovementAnimatorController()
		{
			LFSZoroark_AnimatorCMA.Z_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeZoroark_IdleAnimatorController()
		{
			LFSZoroark_AnimatorICA.Z_LFS_IdleAnimatorController();
		}
	}
}