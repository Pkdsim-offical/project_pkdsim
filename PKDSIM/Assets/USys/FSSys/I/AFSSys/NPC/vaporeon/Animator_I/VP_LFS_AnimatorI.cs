using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.Animator_I
{
	public class LFS_VaporeonFailSafe : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;
		
		private Vaporeon_LFS_AnimatorControllerCoverterAnimator LFSVaporeon_AnimatorCCA;
		private Vaporeon_LFS_AnimatorBaseMovementController LFSVaporeon_AnimatorCMA;
		private Vaporeon_LFS_AnimatorIdleController LFSVaporeon_AnimatorICA;

		public void LoadFailSafeVaporeon_AnimatorController()
		{
			
		}
		private void LoadFailSafeVaporeon_ConvertToAnimatorController()
		{
			LFSVaporeon_AnimatorCCA.VP_BaseIdleAnimatorController();
		}
		private void LoadFailSafeVaporeon_MovementAnimatorController()
		{
			LFSVaporeon_AnimatorCMA.VP_BaseIdleAnimatorController();
		}
		private void LoadFailSafeVaporeon_IdleAnimatorController()
		{
			LFSVaporeon_AnimatorICA.VP_LFS_BaseIdleAnimatorController();
		}
	}
}