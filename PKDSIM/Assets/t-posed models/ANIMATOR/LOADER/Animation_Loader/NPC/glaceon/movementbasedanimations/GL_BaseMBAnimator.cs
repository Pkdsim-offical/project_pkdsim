using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Running;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.movementbasedanimations
{
	public class Glaceon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private GL_Jumping GL_MBA_Jumping;
		
		private GL_Running GL_MBA_Running;

		private GL_Turning GL_MBA_Turning;

		private GL_Strafe GL_MBA_Strafe;

		private void GL_BaseIdleAnimatorController()
		{
			GL_MBA_Running.GL_RunningController();

			GL_MBA_Jumping.GL_JumpingController();

			GL_MBA_Turning.GL_TurningController();	

			GL_MBA_Strafe.GL_StrafingController();
		}
	}
}