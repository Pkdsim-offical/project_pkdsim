using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.idlebaseanimation.IdleSitting
{
	public class UM_IdleSitting : MonoBehaviour 
	{
		public Animator Umbreon_Animator;
		public void UM_IdleSittingController()
		{
			Umbreon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Umbreon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}