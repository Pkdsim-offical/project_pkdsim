using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon.Animator_I
{
	public class ES_AnimatorI : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public RuntimeAnimatorController someController;
		
		private void Espeon_AnimatorController()
		{
			Espeon_Animator = gameObject.GetComponent<Animator>();
			Espeon_Animator.runtimeAnimatorController = someController;
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