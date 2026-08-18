using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;
using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.Animator_I
{
	public class LFS_FrostlassFailSafe : AbstractModelAnimator<FrostlassAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.FROSTLASS;

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
        public void LoadFailSafeFrostlass_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.FROSTLASS.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.FROSTLASS.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.FROSTLASS.converteranimations;
 		// public Animator Frostlass_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType frostlass = NPCSpeciesType.FROSTLASS;

		// private Frostlass_LFS_ConverterAnimatorController LFSFrostlass_AnimatorCCA;
		// private Frostlass_LFS_MovementAnimatorController LFSFrostlass_AnimatorCMA;
		// private Frostlass_LFS_IdleAnimatorController LFSFrostlass_AnimatorICA;


		// public void LoadFailSafeFrostlass_AnimatorController()
		// {
		// 	LoadFailSafeFrostlass_ConvertToAnimatorController();
		// 	LoadFailSafeFrostlass_MovementAnimatorController();
		// 	LoadFailSafeFrostlass_IdleAnimatorController();
		// }
		// private void LoadFailSafeFrostlass_ConvertToAnimatorController()
		// {
		// 	LFSFrostlass_AnimatorCCA.FR_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeFrostlass_MovementAnimatorController()
		// {
		// 	LFSFrostlass_AnimatorCMA.FR_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeFrostlass_IdleAnimatorController()
		// {
		// 	LFSFrostlass_AnimatorICA.FR_LFS_IdleAnimatorController();
		// }
	}
}