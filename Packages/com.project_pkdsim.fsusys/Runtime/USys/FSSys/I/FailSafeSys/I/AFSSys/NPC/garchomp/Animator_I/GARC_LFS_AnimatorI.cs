using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;
using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.Animator_I
{
	public class LFS_GarchompFailSafe : AbstractModelAnimator<GarchompAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.GARCHOMP;

        public override Animator GetAnimator(Animator animator)
		{
			return animator;
		}

        public override void PlayAnimation(string animationName)
		{
			
		}

        public override void StopAnimation(string animationName)
		{
			
		}

		// testing
        public void LoadFailSafeGarchomp_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations;

		// public Animator Garchomp_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType garchomp = NPCSpeciesType.GARCHOMP;

		// private Garchomp_LFS_ConverterAnimatorController LFSGarchomp_AnimatorCCA;
		// private Garchomp_LFS_MovementAnimatorController LFSGarchomp_AnimatorCMA;
		// private Garchomp_LFS_IdleAnimatorController LFSGarchomp_AnimatorICA;


		// public void LoadFailSafeGarchomp_AnimatorController()
		// {
		// 	LoadFailSafeGarchomp_ConvertToAnimatorController();
		// 	LoadFailSafeGarchomp_MovementAnimatorController();
		// 	LoadFailSafeGarchomp_IdleAnimatorController();
		// }
		// private void LoadFailSafeGarchomp_ConvertToAnimatorController()
		// {
		// 	LFSGarchomp_AnimatorCCA.GARC_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeGarchomp_MovementAnimatorController()
		// {
		// 	LFSGarchomp_AnimatorCMA.GARC_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeGarchomp_IdleAnimatorController()
		// {
		// 	LFSGarchomp_AnimatorICA.GARC_LFS_IdleAnimatorController();
		// }
	}
}