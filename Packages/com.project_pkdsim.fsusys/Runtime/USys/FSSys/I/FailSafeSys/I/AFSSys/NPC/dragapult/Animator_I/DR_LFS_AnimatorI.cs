using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.Animator_I
{
	public class LFS_DragapultFailSafe : AbstractModelAnimator<DragapultAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.DRAGAPULT;

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
        public void LoadFailSafeDragapult_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations;

		// public Animator Dragapult_Animator;
		// public RuntimeAnimatorController someController;

		// private NPCSpeciesType dragapult = NPCSpeciesType.DRAGAPULT;

		// private Dragapult_LFS_ConverterAnimatorController LFSDragapult_AnimatorCCA;
		// private Dragapult_LFS_MovementAnimatorController LFSDragapult_AnimatorCMA;
		// private Dragapult_LFS_IdleAnimatorController LFSDragapult_AnimatorICA;


		// public void LoadFailSafeDragapult_AnimatorController()
		// {
		// 	LoadFailSafeDragapult_ConvertToAnimatorController();
		// 	LoadFailSafeDragapult_MovementAnimatorController();
		// 	LoadFailSafeDragapult_IdleAnimatorController();
		// }
		// private void LoadFailSafeDragapult_ConvertToAnimatorController()
		// {
		// 	LFSDragapult_AnimatorCCA.DR_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeDragapult_MovementAnimatorController()
		// {
		// 	LFSDragapult_AnimatorCMA.DR_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeDragapult_IdleAnimatorController()
		// {
		// 	LFSDragapult_AnimatorICA.DR_LFS_IdleAnimatorController();
		// }
	}
}