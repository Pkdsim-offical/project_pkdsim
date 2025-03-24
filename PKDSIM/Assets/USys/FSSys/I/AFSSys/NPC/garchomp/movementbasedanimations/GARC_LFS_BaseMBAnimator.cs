using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations
{
	public class Garchomp_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private GARC_LFS_Jumping Garchomp_MBA_Jumping;
		
		private GARC_LFS_Running Garchomp_MBA_Running;


		private GARC_LFS_Turning Garchomp_MBA_Turning;

		private GARC_LFS_Strafing Garchomp_MBA_Strafe;

		public void GARC_LFS_MovementAnimatorController()
		{
			Garchomp_MBA_Running.GARC_LFS_RunningController();

			Garchomp_MBA_Jumping.GARC_LFS_JumpingController();

			Garchomp_MBA_Turning.GARC_LFS_TurningController();	

			Garchomp_MBA_Strafe.GARC_LFS_StrafingController();
		}
	}
}