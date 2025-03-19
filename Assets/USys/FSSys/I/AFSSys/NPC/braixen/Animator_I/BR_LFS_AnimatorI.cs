using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.idlebaseanimation;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.Animator_I
{
	public class LFS_BraixenFailSafe : MonoBehaviour 
	{
		public Animator Braixen_Animator;
		public RuntimeAnimatorController someController;

		private Braixen_LFS_CoverterAnimatorController LFSBraixen_AnimatorCCA;
		private Braixen_LFS_AnimatorBaseMovementController LFSBraixen_AnimatorCMA;
		private Braixen_LFS_IdleAnimatorController LFSBraixen_AnimatorICA;


		public void LoadFailSafeBraixen_AnimatorController()
		{
			LoadFailSafeBraixen_ConvertToAnimatorController();
			LoadFailSafeBraixen_MovementAnimatorController();
			LoadFailSafeBraixen_IdleAnimatorController();
		}
		private void LoadFailSafeBraixen_ConvertToAnimatorController()
		{
			LFSBraixen_AnimatorCCA.BR_LFS_CoverterToAnimatorController();
		}
		private void LoadFailSafeBraixen_MovementAnimatorController()
		{
			LFSBraixen_AnimatorCMA.BR_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeBraixen_IdleAnimatorController()
		{
			LFSBraixen_AnimatorICA.BR_LFS_IdleAnimatorController();
		}
	}
}