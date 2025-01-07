using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.idlebaseanimations.IdleSitting
{
	public class LE_LFS_IdleSitting : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public void LE_LFS_IdleSittingController()
		{
			Leafeon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Leafeon_Animator.Play("Idle_Sitting");         // Start in the Idle animation state
		}
	}
}