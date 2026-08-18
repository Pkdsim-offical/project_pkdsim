using project_pkdsim.Generics.NPC.Species.Type;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Abstractors.ANIMATOR.Model;

using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.Animator_I
{
	public class LFS_BraixenFailSafe : AbstractModelAnimator<BraixenAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.BRAIXEN;

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
        public void LoadFailSafeBraixen_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations;

		// public Animator Braixen_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType braixen = NPCSpeciesType.BRAIXEN;

		// private Braixen_LFS_ConverterAnimatorController LFSBraixen_AnimatorCCA;
		// private Braixen_LFS_MovementAnimatorController LFSBraixen_AnimatorCMA;
		// private Braixen_LFS_IdleAnimatorController LFSBraixen_AnimatorICA;


		// public void LoadFailSafeBraixen_AnimatorController()
		// {
		// 	LoadFailSafeBraixen_ConvertToAnimatorController();
		// 	LoadFailSafeBraixen_MovementAnimatorController();
		// 	LoadFailSafeBraixen_IdleAnimatorController();
		// }
		// private void LoadFailSafeBraixen_ConvertToAnimatorController()
		// {
		// 	LFSBraixen_AnimatorCCA.BR_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeBraixen_MovementAnimatorController()
		// {
		// 	LFSBraixen_AnimatorCMA.BR_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeBraixen_IdleAnimatorController()
		// {
		// 	LFSBraixen_AnimatorICA.BR_LFS_IdleAnimatorController();
		// }
	}
}