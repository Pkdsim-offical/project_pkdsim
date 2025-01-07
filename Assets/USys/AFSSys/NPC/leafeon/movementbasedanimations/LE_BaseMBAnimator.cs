using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations
{
	public class Leafeon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private LE_LFS_Jumping LE_MBA_Jumping;
		
		private LE_LFS_Running LE_MBA_Running;

		private LE_LFS_Turning LE_MBA_Turning;

		private LE_LFS_Strafing LE_MBA_Strafe;

		private void LE_BaseIdleAnimatorController()
		{
			LE_MBA_Running.LE_LFS_RunningController();

			LE_MBA_Jumping.LE_LFS_JumpingController();

			LE_MBA_Turning.LE_LFS_TurningController();	

			LE_MBA_Strafe.LE_LFS_StrafingController();
		}
	}
}