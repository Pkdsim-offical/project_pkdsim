using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.idlebaseanimation.IdleSitting
{
	public class VP_IdleSitting : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public void VP_IdleSittingController()
		{
			Vaporeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Vaporeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}