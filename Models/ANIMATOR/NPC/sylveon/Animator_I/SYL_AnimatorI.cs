using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Sylveon.Animator_I
{
	public class SYL_AnimatorI : MonoBehaviour 
	{
		public Animator Sylveon_Animator;
		public RuntimeAnimatorController someController;
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