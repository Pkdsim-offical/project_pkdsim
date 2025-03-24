using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.movementbasedanimations;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.converteranimations;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.idlebaseanimation;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Leafeon.Animator_I
{
	public class LE_AnimatorI : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;

		private Leafeon_CoverterAnimatorController Leafeon_AnimatorCCA;
		private Leafeon_AnimatorBaseMovementController Leafeon_AnimatorCMA;
		private Leafeon_IdleAnimatorController  Leafeon_AnimatorICA;

		private void Leafeon_AnimatorController()
		{
			Leafeon_Animator = gameObject.GetComponent<Animator>();
			Leafeon_Animator.runtimeAnimatorController = someController;
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