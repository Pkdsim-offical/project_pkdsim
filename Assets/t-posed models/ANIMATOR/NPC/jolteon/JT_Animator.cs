using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Jolteon
{
	public class JT_Animator : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private void Jolteon_AnimatorController()
		{
			Jolteon_Animator = gameObject.GetComponent<Animator>();
			Jolteon_Animator.runtimeAnimatorController = someController;
		}
	}
}