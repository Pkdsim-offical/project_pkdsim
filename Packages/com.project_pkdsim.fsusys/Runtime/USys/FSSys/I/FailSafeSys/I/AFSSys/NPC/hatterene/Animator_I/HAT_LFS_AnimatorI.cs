using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.Animator_I
{
	public class LFS_HattereneFailSafe : AbstractModelAnimator<HattereneAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.HATTERENE;

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
        public void LoadFailSafeHatterene_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations;
		// public Animator Hatterene_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType hatterene = NPCSpeciesType.HATTERENE;

		// private Hatterene_LFS_ConverterAnimatorController LFSHatterene_AnimatorCCA;
		// private Hatterene_LFS_MovementAnimatorController LFSHatterene_AnimatorCMA;
		// private Hatterene_LFS_IdleAnimatorController LFSHatterene_AnimatorICA;


		// public void LoadFailSafeHatterene_AnimatorController()
		// {
		// 	LoadFailSafeHatterene_ConvertToAnimatorController();
		// 	LoadFailSafeHatterene_MovementAnimatorController();
		// 	LoadFailSafeHatterene_IdleAnimatorController();
		// }
		// private void LoadFailSafeHatterene_ConvertToAnimatorController()
		// {
		// 	LFSHatterene_AnimatorCCA.HAT_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeHatterene_MovementAnimatorController()
		// {
		// 	LFSHatterene_AnimatorCMA.HAT_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeHatterene_IdleAnimatorController()
		// {
		// 	LFSHatterene_AnimatorICA.HAT_LFS_IdleAnimatorController();
		// }
	}
}