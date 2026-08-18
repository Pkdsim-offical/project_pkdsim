using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;

using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.Animator_I
{
	public class LFS_BlazikenFailSafe : AbstractModelAnimator<BlazikenAnimator>
	{
        public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.BLAZIKEN;

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
        public void LoadFailSafeBlaziken_AnimatorController()
        {
        }

		// pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.converteranimations;

		// public Animator Blaziken_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType blaziken = NPCSpeciesType.BLAZIKEN;

		// private Blaziken_LFS_ConverterAnimatorController LFSBlaziken_AnimatorCCA;
		// private Blaziken_LFS_MovementAnimatorController LFSBlaziken_AnimatorCMA;
		// private Blaziken_LFS_IdleAnimatorController LFSBlaziken_AnimatorICA;


		// public void LoadFailSafeBlaziken_AnimatorController()
		// {
		// 	LoadFailSafeBlaziken_ConvertToAnimatorController();
		// 	LoadFailSafeBlaziken_MovementAnimatorController();
		// 	LoadFailSafeBlaziken_IdleAnimatorController();
		// }
		// private void LoadFailSafeBlaziken_ConvertToAnimatorController()
		// {
		// 	LFSBlaziken_AnimatorCCA.BL_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeBlaziken_MovementAnimatorController()
		// {
		// 	LFSBlaziken_AnimatorCMA.BL_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeBlaziken_IdleAnimatorController()
		// {
		// 	LFSBlaziken_AnimatorICA.BL_LFS_IdleAnimatorController();
		// }
	}
}