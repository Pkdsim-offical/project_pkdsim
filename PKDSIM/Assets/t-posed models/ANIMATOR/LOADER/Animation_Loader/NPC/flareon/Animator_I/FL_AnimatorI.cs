using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Flareon.converteranimations;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Flareon.idlebaseanimation;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Flareon.movementbasedanimations;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.NPC.Flareon.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private Flareon_AnimatorConverterController Flareon_AnimatorCCA;
		private Flareon_AnimatorBaseMovementController Flareon_AnimatorCMA;
		private Flareon_AnimatorIdleController Flareon_AnimatorICA;
		
		private void Flareon_AnimatorController()
		{
			// Flareon_Animator = gameObject.GetComponent<Animator>();
			// Flareon_Animator.runtimeAnimatorController = someController;
		}
		private void ConvertToAnimatorController()
		{
			//Flareon_AnimatorCCA;
		}
		private void MovementAnimatorController()
		{
			//Flareon_AnimatorCMA	;
		}
		private void IdleAnimatorController()
		{
			//Flareon_AnimatorICA;		
		}
	}
}