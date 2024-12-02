using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon.Animator_I
{
	public class JT_AnimatorI : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private void Jolteon_AnimatorController()
		{
			Jolteon_Animator = gameObject.GetComponent<Animator>();
			Jolteon_Animator.runtimeAnimatorController = someController;
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