using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations
{
	public class Absol_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private AB_LFS_Jumping AB_MBA_Jumping;
		
		private AB_LFS_Running AB_MBA_Running;


		private AB_LFS_Turning AB_MBA_Turning;

		private AB_LFS_Strafing AB_MBA_Strafe;

		public void AB_LFS_MovementAnimatorController()
		{
			AB_MBA_Running.AB_LFS_RunningController();

			AB_MBA_Jumping.AB_LFS_JumpingController();

			AB_MBA_Turning.AB_LFS_TurningController();	

			AB_MBA_Strafe.AB_LFS_StrafingController();
		}
	}
}