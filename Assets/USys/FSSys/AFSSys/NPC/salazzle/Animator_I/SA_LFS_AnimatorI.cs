using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.Animator_I
{
	public class LFS_SalazzleFailSafe : MonoBehaviour 
	{
		public Animator Salazzle_Animator;
		public RuntimeAnimatorController someController;

		private Salazzle_LFS_CoverterAnimatorController LFSSalazzle_AnimatorCCA;
		private Salazzle_LFS_AnimatorBaseMovementController LFSSalazzle_AnimatorCMA;
		private Salazzle_LFS_IdleAnimatorController LFSSalazzle_AnimatorICA;


		public void LoadFailSafeSalazzle_AnimatorController()
		{
			LoadFailSafeSalazzle_ConvertToAnimatorController();
			LoadFailSafeSalazzle_MovementAnimatorController();
			LoadFailSafeSalazzle_IdleAnimatorController();
		}
		private void LoadFailSafeSalazzle_ConvertToAnimatorController()
		{
			LFSSalazzle_AnimatorCCA.SA_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeSalazzle_MovementAnimatorController()
		{
			LFSSalazzle_AnimatorCMA.SA_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeSalazzle_IdleAnimatorController()
		{
			LFSSalazzle_AnimatorICA.SA_LFS_IdleAnimatorController();
		}
	}
}