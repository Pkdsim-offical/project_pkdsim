using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Glaceon.Animator_I
{
	public class GL_AnimatorI : MonoBehaviour 
	{
		public Animator Glaceon_Animator;
		public RuntimeAnimatorController someController;

		private void Glaceon_AnimatorController()
		{
			Glaceon_Animator = gameObject.GetComponent<Animator>();
			Glaceon_Animator.runtimeAnimatorController = someController;
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