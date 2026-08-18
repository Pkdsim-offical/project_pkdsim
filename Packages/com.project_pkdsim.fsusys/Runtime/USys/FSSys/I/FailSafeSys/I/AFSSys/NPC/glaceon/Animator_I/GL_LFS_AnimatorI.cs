using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;
using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.Animator_I
{
	public class LFS_GlaceonFailSafe : AbstractModelAnimator<GlaceonAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.GLACEON;

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
        public void LoadFailSafeGlaceon_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Glaceon.converteranimations;
		// public Animator Glaceon_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType glaceon = NPCSpeciesType.GLACEON;

		// private Glaceon_LFS_ConverterAnimatorController LFSGlaceon_AnimatorCCA;
		// private GLaceon_LFS_MovementBasedAnimatorController LFSGlaceon_AnimatorCMA;
		// private Glaceon_LFS_IdleAnimatorController LFSGlaceon_AnimatorICA;

		// public void LoadFailSafeGlaceon_AnimatorController()
		// {
		// 	LoadFailSafeGlaceon_ConvertToAnimatorController();
		// 	LoadFailSafeGlaceon_MovementAnimatorController();
		// 	LoadFailSafeGlaceon_IdleAnimatorController();
		// }
		// private void LoadFailSafeGlaceon_ConvertToAnimatorController()
		// {
		// 	LFSGlaceon_AnimatorCCA.GL_LFS_ConvertToAnimatorController();
		// }
		// private void LoadFailSafeGlaceon_MovementAnimatorController()
		// {
		// 	LFSGlaceon_AnimatorCMA.GL_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeGlaceon_IdleAnimatorController()
		// {
		// 	LFSGlaceon_AnimatorICA.GL_LFS_IdleAnimatorController();
		// }
	}
}
