using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.idlebaseanimation.IdleSitting
{
	public class LE_IdleSitting : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public void LE_IdleSittingController()
		{
			Leafeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Leafeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}