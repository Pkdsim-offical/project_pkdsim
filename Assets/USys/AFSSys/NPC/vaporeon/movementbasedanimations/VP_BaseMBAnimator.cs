using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations
{
	public class Vaporeon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private VP_LFS_Jumping VP_MBA_Jumping;
		
		private VP_LFS_Running VP_MBA_Running;

		private VP_LFS_Turning VP_MBA_Turning;

		private VP_LFS_Strafing VP_MBA_Strafe;

		private void VP_BaseIdleAnimatorController()
		{
			VP_MBA_Running.VP_LFS_RunningController();

			VP_MBA_Jumping.VP_LFS_JumpingController();

			VP_MBA_Turning.VP_LFS_TurningController();	

			VP_MBA_Strafe.VP_LFS_StrafingController();
		}
	}
}