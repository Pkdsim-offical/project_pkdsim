using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations
{
	public class Frostlass_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private FR_LFS_Jumping Frostlass_MBA_Jumping;
		
		private FR_LFS_Running Frostlass_MBA_Running;


		private FR_LFS_Turning Frostlass_MBA_Turning;

		private FR_LFS_Strafing Frostlass_MBA_Strafe;

		public void FR_LFS_MovementAnimatorController()
		{
			Frostlass_MBA_Running.FR_LFS_RunningController();

			Frostlass_MBA_Jumping.FR_LFS_JumpingController();

			Frostlass_MBA_Turning.FR_LFS_TurningController();	

			Frostlass_MBA_Strafe.FR_LFS_StrafingController();
		}
	}
}