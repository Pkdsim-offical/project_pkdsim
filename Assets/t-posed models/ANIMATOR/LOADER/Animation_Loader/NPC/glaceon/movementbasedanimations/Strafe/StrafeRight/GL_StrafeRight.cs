using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Strafe.StrafeRight
{
	public class GL_StrafeRight : MonoBehaviour
	{
		private Animator Glaceon_Animator;
		private void GL_StrafeRightController()
		{
			Glaceon_Animator.SetFloat("Speed", 0f); // Initialize speed to 0
			Glaceon_Animator.Play("Strafe_Right");         // Start in the Idle animation state
		}
	}
}