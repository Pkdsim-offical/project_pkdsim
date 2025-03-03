using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations
{
	public class Zoroark_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private Z_LFS_Jumping Zoroark_MBA_Jumping;
		
		private Z_LFS_Running Zoroark_MBA_Running;


		private Z_LFS_Turning Zoroark_MBA_Turning;

		private Z_LFS_Strafing Zoroark_MBA_Strafe;

		public void Z_LFS_MovementAnimatorController()
		{
			Zoroark_MBA_Running.Z_LFS_RunningController();

			Zoroark_MBA_Jumping.Z_LFS_JumpingController();

			Zoroark_MBA_Turning.Z_LFS_TurningController();	

			Zoroark_MBA_Strafe.Z_LFS_StrafingController();
		}
	}
}