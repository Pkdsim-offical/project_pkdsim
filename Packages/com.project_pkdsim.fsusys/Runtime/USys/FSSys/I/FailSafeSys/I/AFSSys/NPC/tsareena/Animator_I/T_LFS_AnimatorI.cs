using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.Animator_I
{
	public class LFS_TsareenaFailSafe : MonoBehaviour 
	{
		public Animator Tsareena_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType tsareena = NPCSpeciesType.TSAREENA;

		private Tsareena_LFS_ConverterAnimatorController LFSTsareena_AnimatorCCA;
		private Tsareena_LFS_MovementAnimatorController LFSTsareena_AnimatorCMA;
		private Tsareena_LFS_IdleAnimatorController LFSTsareena_AnimatorICA;


		public void LoadFailSafeTsareena_AnimatorController()
		{
			LoadFailSafeTsareena_ConvertToAnimatorController();
			LoadFailSafeTsareena_MovementAnimatorController();
			LoadFailSafeTsareena_IdleAnimatorController();
		}
		private void LoadFailSafeTsareena_ConvertToAnimatorController()
		{
			LFSTsareena_AnimatorCCA.T_LFS_ConverterAnimatorController();
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