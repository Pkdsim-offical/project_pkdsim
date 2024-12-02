
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.idlebaseanimation;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.converteranimations;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.NPC.Umbreon.Animator_I
{
	public class UM_AnimatorI : MonoBehaviour 
	{		
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;

		private Umbreon_AnimatorBaseConverterController Umbreon_AnimatorCCA;
		private Umbreon_AnimatorBaseMovementController Umbreon_AnimatorCMA;
		private Umbreon_AnimatorIdleController Umbreon_AnimatorICA;

		public void Umbreon_AnimatorController()
		{
			Umbreon_Animator.runtimeAnimatorController = someController;
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