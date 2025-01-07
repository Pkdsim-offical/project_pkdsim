using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Sylveon.movementbasedanimations
{
	public class Sylveon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private SYL_LFS_Jumping SYL_MBA_Jumping;
		
		private SYL_LFS_Running SYL_MBA_Running;

		private SYL_LFS_Turning SYL_MBA_Turning;

		private SYL_LFS_Strafing SYL_MBA_Strafe;

		private void SYL_BaseIdleAnimatorController()
		{
			SYL_MBA_Running.SYL_LFS_RunningController();

			SYL_MBA_Jumping.SYL_LFS_JumpingController();

			SYL_MBA_Turning.SYL_LFS_TurningController();	

			SYL_MBA_Strafe.SYL_LFS_StrafingController();
		}	
	}
}