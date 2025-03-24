using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Running;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.movementbasedanimations
{
	public class Vaporeon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private VP_Jumping VP_MBA_Jumping;
		
		private VP_Running VP_MBA_Running;

		private VP_Turning VP_MBA_Turning;

		private VP_Strafing VP_MBA_Strafe;

		private void VP_BaseIdleAnimatorController()
		{
			VP_MBA_Running.VP_RunningController();

			VP_MBA_Jumping.VP_JumpingController();

			VP_MBA_Turning.VP_TurningController();	

			VP_MBA_Strafe.VP_StrafingController();
		}
	}
}