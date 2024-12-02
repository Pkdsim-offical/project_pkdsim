using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon.Animator_I
{
	public class FL_AnimatorI : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private void Flareon_AnimatorController()
		{
			Flareon_Animator = gameObject.GetComponent<Animator>();
			Flareon_Animator.runtimeAnimatorController = someController;
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