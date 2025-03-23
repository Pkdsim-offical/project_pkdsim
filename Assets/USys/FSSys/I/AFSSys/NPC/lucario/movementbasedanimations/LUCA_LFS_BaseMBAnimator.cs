using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations
{
	public class Lucario_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private LUCA_LFS_Jumping Lucario_MBA_Jumping;
		
		private LUCA_LFS_Running Lucario_MBA_Running;


		private LUCA_LFS_Turning Lucario_MBA_Turning;

		private LUCA_LFS_Strafing Lucario_MBA_Strafe;

		public void LUCA_LFS_MovementAnimatorController()
		{
			Lucario_MBA_Running.LUCA_LFS_RunningController();

			Lucario_MBA_Jumping.LUCA_LFS_JumpingController();

			Lucario_MBA_Turning.LUCA_LFS_TurningController();	

			Lucario_MBA_Strafe.LUCA_LFS_StrafingController();
		}
	}
}