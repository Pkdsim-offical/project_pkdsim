using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.converteranimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.Animator_I
{
	public class LFS_SylveonFailSafe: MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_LFS_CoverterAnimatorController Sylveon_AnimatorCCA;
		private Sylveon_LFS_AnimatorBaseMovementController Sylveon_AnimatorCMA;
		private Sylveon_LFS_IdleAnimatorController Sylveon_AnimatorICA;

		public void LoadFailSafeSylveon_AnimatorController()
		{
			Sylveon_Animator = gameObject.GetComponent<Animator>();
			Sylveon_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{

		}
		private void MovementAnimatorController()
		{
			
		}
		private void IdleAnimatorController()
		{
			
		}
	}
}