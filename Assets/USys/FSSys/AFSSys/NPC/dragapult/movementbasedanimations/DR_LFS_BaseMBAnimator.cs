using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations
{
	public class Dragapult_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private DR_LFS_Jumping DR_MBA_Jumping;
		
		private DR_LFS_Running DR_MBA_Running;


		private DR_LFS_Turning DR_MBA_Turning;

		private DR_LFS_Strafing DR_MBA_Strafe;

		public void DR_LFS_MovementAnimatorController()
		{
			DR_MBA_Running.DR_LFS_RunningController();

			DR_MBA_Jumping.DR_LFS_JumpingController();

			DR_MBA_Turning.DR_LFS_TurningController();	

			DR_MBA_Strafe.DR_LFS_StrafingController();
		}
	}
}