using project_pkdsim.Generics.ANIMATOR.Type.Model;
using project_pkdsim.Generics.NPC.Species.Type;
using project_pkdsim.Abstractors.ANIMATOR.Model;

using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.Animator_I
{
	public class LFS_BeedrillFailSafe : AbstractModelAnimator<BeedrillAnimator>
	{

        public override Animator Animator => Animator;

        public override RuntimeAnimatorController someController => someController;

        public override NPCSpeciesType SpeciesType => NPCSpeciesType.BEEDRILL;

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
        public void LoadFailSafeBeedrill_AnimatorController()
        {
        }

        // pre interface

        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.idlebaseanimation;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations;
        // using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations;

        // 	public Animator Beedrill_Animator;
        // 	public RuntimeAnimatorController someController;

        // 	private NPCSpeciesType beedrill = NPCSpeciesType.BEEDRILL;

        // 	private Beedrill_LFS_ConverterAnimatorController LFSBeedrill_AnimatorCCA;
        // 	private Beedrill_LFS_MovementAnimatorController LFSBeedrill_AnimatorCMA;
        // 	private Beedrill_LFS_IdleAnimatorController LFSBeedrill_AnimatorICA;


        // 	public void LoadFailSafeBeedrill_AnimatorController()
        // 	{
        // 		LoadFailSafeBeedrill_ConvertToAnimatorController();
        // 		LoadFailSafeBeedrill_MovementAnimatorController();
        // 		LoadFailSafeBeedrill_IdleAnimatorController();
        // 	}
        // 	private void LoadFailSafeBeedrill_ConvertToAnimatorController()
        // 	{
        // 		LFSBeedrill_AnimatorCCA.BE_LFS_ConverterAnimatorController();
        // 	}
        // 	private void LoadFailSafeBeedrill_MovementAnimatorController()
        // 	{
        // 		LFSBeedrill_AnimatorCMA.BE_LFS_MovementAnimatorController();
        // 	}
        // 	private void LoadFailSafeBeedrill_IdleAnimatorController()
        // 	{
        // 		LFSBeedrill_AnimatorICA.BE_LFS_IdleAnimatorController();
        // 	}
    }
}
