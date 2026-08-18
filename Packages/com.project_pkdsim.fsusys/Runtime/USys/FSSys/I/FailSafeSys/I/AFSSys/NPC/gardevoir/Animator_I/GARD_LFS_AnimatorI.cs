using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;
using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.Animator_I
{
	public class LFS_GardevoirFailSafe : AbstractModelAnimator<GardeviorAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.GARDEVOIR;

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
        public void LoadFailSafeGardevoir_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations;

		// public Animator Gardevoir_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType gardevoir = NPCSpeciesType.GARDEVOIR;

		// private Gardevoir_LFS_ConverterAnimatorController LFSGardevoir_AnimatorCCA;
		// private Gardevoir_LFS_MovementAnimatorController LFSGardevoir_AnimatorCMA;
		// private Gardevoir_LFS_IdleAnimatorController LFSGardevoir_AnimatorICA;

		// public void LoadFailSafeGardevoir_AnimatorController()
		// {
		// 	LoadFailSafeGardevoir_ConvertToAnimatorController();
		// 	LoadFailSafeGardevoir_MovementAnimatorController();
		// 	LoadFailSafeGardevoir_IdleAnimatorController();
		// }
		// private void LoadFailSafeGardevoir_ConvertToAnimatorController()
		// {
		// 	LFSGardevoir_AnimatorCCA.GARD_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeGardevoir_MovementAnimatorController()
		// {
		// 	LFSGardevoir_AnimatorCMA.GARD_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeGardevoir_IdleAnimatorController()
		// {
		// 	LFSGardevoir_AnimatorICA.GARD_LFS_IdleAnimatorController();
		// }
	}
}
