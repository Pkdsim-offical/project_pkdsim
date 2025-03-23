using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.Animator_I
{
	public class LFS_SylveonFailSafe: MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_LFS_CoverterAnimatorController LFSSylveon_AnimatorCCA;
		private Sylveon_LFS_AnimatorBaseMovementController LFSSylveon_AnimatorCMA;
		private Sylveon_LFS_IdleAnimatorController LFSSylveon_AnimatorICA;


		public void LoadFailSafeSylveon_AnimatorController()
		{
			LoadFailSafeSylveon_ConvertToAnimatorController();
			LoadFailSafeSylveon_MovementAnimatorController();
			LoadFailSafeSylveon_IdleAnimatorController();
		}
		private void LoadFailSafeSylveon_ConvertToAnimatorController()
		{
			LFSSylveon_AnimatorCCA.SYL_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeSylveon_MovementAnimatorController()
		{
			LFSSylveon_AnimatorCMA.SYL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeSylveon_IdleAnimatorController()
		{
			LFSSylveon_AnimatorICA.SYL_LFS_IdleAnimatorController();
		}
	}
}