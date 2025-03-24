using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.Animator_I
{
	public class LFS_PrimarinaFailSafe : MonoBehaviour 
	{
		public Animator Primarina_Animator;
		public RuntimeAnimatorController someController;

		private Primarina_LFS_CoverterAnimatorController LFSPrimarina_AnimatorCCA;
		private Primarina_LFS_AnimatorBaseMovementController LFSPrimarina_AnimatorCMA;
		private Primarina_LFS_IdleAnimatorController LFSPrimarina_AnimatorICA;


		public void LoadFailSafePrimarina_AnimatorController()
		{
			LoadFailSafePrimarina_ConvertToAnimatorController();
			LoadFailSafePrimarina_MovementAnimatorController();
			LoadFailSafePrimarina_IdleAnimatorController();
		}
		private void LoadFailSafePrimarina_ConvertToAnimatorController()
		{
			LFSPrimarina_AnimatorCCA.PR_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafePrimarina_MovementAnimatorController()
		{
			LFSPrimarina_AnimatorCMA.PR_LFS_MovementAnimatorController();
		}
		private void LoadFailSafePrimarina_IdleAnimatorController()
		{
			LFSPrimarina_AnimatorICA.PR_LFS_IdleAnimatorController();
		}
	}
}