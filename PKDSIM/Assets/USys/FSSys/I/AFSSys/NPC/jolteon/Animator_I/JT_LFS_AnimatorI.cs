using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.Animator_I
{
	public class LFS_JolteonFailSafe : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private Jolteon_LFS_AnimatorControllerCoverterAnimator LFSJolteon_AnimatorCCA;
		private Jolteon_LFS_AnimatorMovementController LFSJolteon_AnimatorCMA;
		private Jolteon_LFS_AnimatorIdleController LFSJolteon_AnimatorICA;

		public void LoadFailSafeJolteon_AnimatorController()
		{
			LoadFailSafeJolteon_ConvertToAnimatorController();
			LoadFailSafeJolteon_MovementAnimatorController();
			LoadFailSafeJolteon_IdleAnimatorController();
		}
		private void LoadFailSafeJolteon_ConvertToAnimatorController()
		{
			LFSJolteon_AnimatorCCA.JT_LFS_IdleAnimatorController();
		}
		private void LoadFailSafeJolteon_MovementAnimatorController()
		{
			LFSJolteon_AnimatorCMA.JT_LFS_BaseIdleAnimatorController();
		}
		private void LoadFailSafeJolteon_IdleAnimatorController()
		{
			LFSJolteon_AnimatorICA.JT_LFS_BaseIdleAnimatorController();
		}
	}
}