using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Espeon.movementbasedanimations
{
	public class Espeon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private ES_LFS_Jumping ES_MBA_Jumping;
		
		private ES_LFS_Running ES_MBA_Running;

		private ES_LFS_Turning ES_MBA_Turning;

		private ES_LFS_Strafing ES_MBA_Strafe;

		private void ES_BaseIdleAnimatorController()
		{
			ES_MBA_Running.ES_LFS_RunningController();

			ES_MBA_Jumping.ES_LFS_JumpingController();

			ES_MBA_Turning.ES_LFS_TurningController();	

			ES_MBA_Strafe.ES_LFS_StrafingController();
		}
	}
}