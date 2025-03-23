
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.Animator_I
{
	public class LFS_GlaceonFailSafe : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public RuntimeAnimatorController someController;

		private Glaceon_LFS_CoverterAnimatorController LFSGlaceon_AnimatorCCA;
		private GLaceon_LFS_MovementBasedAnimatorController LFSGlaceon_AnimatorCMA;
		private Glaceon_LFS_IdleAnimatorController LFSGlaceon_AnimatorICA;

		public void LoadFailSafeGlaceon_AnimatorController()
		{
			LoadFailSafeGlaceon_ConvertToAnimatorController();
			LoadFailSafeGlaceon_MovementAnimatorController();
			LoadFailSafeGlaceon_IdleAnimatorController();
		}
		private void LoadFailSafeGlaceon_ConvertToAnimatorController()
		{
			LFSGlaceon_AnimatorCCA.GL_LFS_ConvertToAnimatorController();
		}
		private void LoadFailSafeGlaceon_MovementAnimatorController()
		{
			LFSGlaceon_AnimatorCMA.GL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeGlaceon_IdleAnimatorController()
		{
			LFSGlaceon_AnimatorICA.GL_LFS_IdleAnimatorController();
		}
	}
}