using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations
{
	public class Gardevoir_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private GARD_LFS_Jumping Gardevoir_MBA_Jumping;
		
		private GARD_LFS_Running Gardevoir_MBA_Running;


		private GARD_LFS_Turning Gardevoir_MBA_Turning;

		private GARD_LFS_Strafing Gardevoir_MBA_Strafe;

		public void GARD_LFS_MovementAnimatorController()
		{
			Gardevoir_MBA_Running.GARD_LFS_RunningController();

			Gardevoir_MBA_Jumping.GARD_LFS_JumpingController();

			Gardevoir_MBA_Turning.GARD_LFS_TurningController();	

			Gardevoir_MBA_Strafe.GARD_LFS_StrafingController();
		}
	}
}