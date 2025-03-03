using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private Tsareena_LFS_CoverterAnimatorController LFSTsareena_AnimatorCCA;
		private Tsareena_LFS_AnimatorBaseMovementController LFSTsareena_AnimatorCMA;
		private Tsareena_LFS_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.T_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeTsareena_MovementAnimatorController()
		{
			LFSTsareena_AnimatorCMA.T_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeTsareena_IdleAnimatorController()
		{
			LFSTsareena_AnimatorICA.T_LFS_IdleAnimatorController();
		}
	}
}