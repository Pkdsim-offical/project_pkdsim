using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.idlebaseanimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.Animator_I
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

		}
		private void LoadFailSafeLeafeon_MovementAnimatorController()
		{
			
		}
		private void LoadFailSafeLeafeon_IdleAnimatorController()
		{
			
		}
	}
}