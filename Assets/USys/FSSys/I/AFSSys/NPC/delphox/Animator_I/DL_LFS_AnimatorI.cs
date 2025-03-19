using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.Animator_I
{
	public class LFS_DelphoxFailSafe : MonoBehaviour 
	{
		public Animator Delphox_Animator;
		public RuntimeAnimatorController someController;

		private Delphox_LFS_CoverterAnimatorController LFSDelphox_AnimatorCCA;
		private Delphox_LFS_AnimatorBaseMovementController LFSDelphox_AnimatorCMA;
		private Delphox_LFS_IdleAnimatorController LFSDelphox_AnimatorICA;


		public void LoadFailSafeDelphox_AnimatorController()
		{
			LoadFailSafeDelphox_ConvertToAnimatorController();
			LoadFailSafeDelphox_MovementAnimatorController();
			LoadFailSafeDelphox_IdleAnimatorController();
		}
		private void LoadFailSafeDelphox_ConvertToAnimatorController()
		{
			LFSDelphox_AnimatorCCA.DL_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeDelphox_MovementAnimatorController()
		{
			LFSDelphox_AnimatorCMA.DL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeDelphox_IdleAnimatorController()
		{
			LFSDelphox_AnimatorICA.DL_LFS_IdleAnimatorController();
		}
	}
}