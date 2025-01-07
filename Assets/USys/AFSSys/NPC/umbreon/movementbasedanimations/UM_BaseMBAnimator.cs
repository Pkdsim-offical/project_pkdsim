using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Turning;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Walking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Umbreon.movementbasedanimations
{
	public class Umbreon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private UM_LFS_Jumping UM_MBA_Jumping;
		
		private UM_LFS_Running UM_MBA_Running;

		private UM_LFS_Walking UM_MBA_Walking;

		private UM_LFS_Turning UM_MBA_Turning;

		private UM_LFS_Strafing UM_MBA_Strafe;

		private void UM_BaseIdleAnimatorController()
		{
			UM_MBA_Running.UM_LFS_RunningController();

			UM_MBA_Jumping.UM_LFS_JumpingController();

			UM_MBA_Walking.UM_LFS_WalkingController();

			UM_MBA_Turning.UM_LFS_TurningController();	

			UM_MBA_Strafe.UM_LFS_StrafingController();
		}	
	}
}