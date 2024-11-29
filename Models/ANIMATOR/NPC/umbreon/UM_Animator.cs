using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Umbreon
{
	public class UM_Animator : MonoBehaviour 
	{
		public Animator Umbreon_Animator;
		public RuntimeAnimatorController someController;
		private void Umbreon_AnimatorController()
		{
			Umbreon_Animator = gameObject.GetComponent<Animator>();
			Umbreon_Animator.runtimeAnimatorController = someController;
		}
	}
}