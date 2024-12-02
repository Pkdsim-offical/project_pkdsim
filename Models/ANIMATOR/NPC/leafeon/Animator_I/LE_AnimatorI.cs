using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Leafeon.Animator_I
{
	public class LE_AnimatorI : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;
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