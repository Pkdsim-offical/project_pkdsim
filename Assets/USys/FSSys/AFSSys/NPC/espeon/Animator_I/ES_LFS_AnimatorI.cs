using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.Animator_I
{
	public class LFS_EspeonFailSafe : MonoBehaviour 
	{
		private Espeon_LFS_CoverterAnimatorController LFSEspeon_AnimatorCCA;
		private Espeon_LFS_AnimatorBaseMovementController LFSEspeon_AnimatorCMA;
		private Espeon_LFS_AnimatorIdleController LFSEspeon_AnimatorICA;

		public void LoadFailSafeEspeon_AnimatorController()
		{
			LoadFailSafeEspeon_ConvertToAnimatorController();
			LoadFailSafeEspeon_IdleAnimatorController();
			LoadFailSafeEspeon_MovementAnimatorController();
		}
		private void LoadFailSafeEspeon_ConvertToAnimatorController()
		{
			LFSEspeon_AnimatorCCA.ES_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeEspeon_MovementAnimatorController()
		{
			LFSEspeon_AnimatorCMA.ES_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeEspeon_IdleAnimatorController()
		{
			LFSEspeon_AnimatorICA.ES_LFS_IdleAnimatorController();
		}
	}
}