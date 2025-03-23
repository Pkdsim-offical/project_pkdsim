using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations
{
	public class Leafeon_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private LE_LFS_Jumping Leafeon_MBA_Jumping;
		
		private LE_LFS_Running Leafeon_MBA_Running;

		private LE_LFS_Turning Leafeon_MBA_Turning;

		private LE_LFS_Strafing Leafeon_MBA_Strafe;

		public void LE_LFS_MovementAnimatorController()
		{
			Leafeon_MBA_Running.LE_LFS_RunningController();

			Leafeon_MBA_Jumping.LE_LFS_JumpingController();

			Leafeon_MBA_Turning.LE_LFS_TurningController();	

			Leafeon_MBA_Strafe.LE_LFS_StrafingController();
		}
	}
}