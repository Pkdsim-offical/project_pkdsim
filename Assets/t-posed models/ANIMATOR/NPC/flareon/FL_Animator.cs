using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Flareon
{
	public class FL_Animator : MonoBehaviour 
	{
		public Animator Flareon_Animator;
		public RuntimeAnimatorController someController;

		private void Flareon_AnimatorController()
		{
			Flareon_Animator = gameObject.GetComponent<Animator>();
			Flareon_Animator.runtimeAnimatorController = someController;
		}
	}
}