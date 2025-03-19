using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.Animator_I
{
	public class LFS_LeafeonFailSafe : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;

		private Leafeon_LFS_AnimatorBaseConverterController LFSLeafeon_AnimatorCCA;
		private Leafeon_LFS_AnimatorBaseMovementController LFSLeafeon_AnimatorCMA;
		private Leafeon_LFS_AnimatorBaseIdleController LFSLeafeon_AnimatorICA;

		public void LoadFailSafeLeafeon_AnimatorController()
		{
			LoadFailSafeLeafeon_ConvertToAnimatorController();
			LoadFailSafeLeafeon_MovementAnimatorController();
			LoadFailSafeLeafeon_IdleAnimatorController();
		}
		private void LoadFailSafeLeafeon_ConvertToAnimatorController()
		{
			LFSLeafeon_AnimatorCCA.LE_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeLeafeon_MovementAnimatorController()
		{
			LFSLeafeon_AnimatorCMA.LE_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeLeafeon_IdleAnimatorController()
		{
			LFSLeafeon_AnimatorICA.LE_LFS_IdleAnimatorController();
		}
	}
}