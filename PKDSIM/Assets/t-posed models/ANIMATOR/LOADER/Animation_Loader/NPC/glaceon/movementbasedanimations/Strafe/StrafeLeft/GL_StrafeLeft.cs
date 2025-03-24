using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Strafe.StrafeLeft
{
	public class GL_StrafeLeft : MonoBehaviour 
	{
		private Animator Glaceon_Animator;
		private void GL_StrafeLeftController()
		{
			Glaceon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Glaceon_Animator.Play("Strafe_Left");         // Start in the Idle animation state
		}
	}
}