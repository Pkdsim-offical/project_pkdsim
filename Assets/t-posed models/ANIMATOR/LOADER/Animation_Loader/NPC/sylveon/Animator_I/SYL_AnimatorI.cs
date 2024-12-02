using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.converteranimations;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.idlebaseanimation;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Sylveon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.NPC.Sylveon.Animator_I
{
	public class SYL_AnimatorI : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;

		private Sylveon_CoverterAnimatorController LFSSylveon_AnimatorCCA;
		private Sylveon_AnimatorBaseMovementController LFSSylveon_AnimatorCMA;
		private Sylveon_IdleAnimatorController LFSSylveon_AnimatorICA;


		private void Sylveon_AnimatorController()
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