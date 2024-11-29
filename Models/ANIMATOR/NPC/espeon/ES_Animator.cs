using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.NPC.Espeon
{
	public class ES_Animator : MonoBehaviour 
	{
		public Animator Espeon_Animator;
		public RuntimeAnimatorController someController;
		
		private void Espeon_AnimatorController()
		{
			Espeon_Animator = gameObject.GetComponent<Animator>();
			Espeon_Animator.runtimeAnimatorController = someController;
		}
	}
}