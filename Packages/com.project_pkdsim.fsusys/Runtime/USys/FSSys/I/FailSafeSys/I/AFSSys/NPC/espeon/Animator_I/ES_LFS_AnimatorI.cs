using project_pkdsim.Abstractors.ANIMATOR.Model;
using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.Animator_I
{
	public class LFS_EspeonFailSafe : AbstractModelAnimator<EspeonAnimator>
	{
		public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.ESPEON;

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
        public void LoadFailSafeEspeon_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations;
 		// private NPCSpeciesType espeon = NPCSpeciesType.ESPEON;

		// private Espeon_LFS_ConverterAnimatorController LFSEspeon_AnimatorCCA;
		// private Espeon_LFS_MovementAnimatorController LFSEspeon_AnimatorCMA;
		// private Espeon_LFS_IdleAnimatorController LFSEspeon_AnimatorICA;

		// public void LoadFailSafeEspeon_AnimatorController()
		// {
		// 	LoadFailSafeEspeon_ConvertToAnimatorController();
		// 	LoadFailSafeEspeon_IdleAnimatorController();
		// 	LoadFailSafeEspeon_MovementAnimatorController();
		// }
		// private void LoadFailSafeEspeon_ConvertToAnimatorController()
		// {
		// 	LFSEspeon_AnimatorCCA.ES_LFS_ConverterAnimatorController();
		// }
		// private void LoadFailSafeEspeon_MovementAnimatorController()
		// {
		// 	LFSEspeon_AnimatorCMA.ES_LFS_MovementAnimatorController();
		// }
		// private void LoadFailSafeEspeon_IdleAnimatorController()
		// {
		// 	LFSEspeon_AnimatorICA.ES_LFS_IdleAnimatorController();
		// }
	}
}