using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations
{
	public class Salazzle_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private SA_LFS_Jumping SA_MBA_Jumping;
		
		private SA_LFS_Running SA_MBA_Running;


		private SA_LFS_Turning SA_MBA_Turning;

		private SA_LFS_Strafing SA_MBA_Strafe;

		public void SA_LFS_MovementAnimatorController()
		{
			SA_MBA_Running.SA_LFS_RunningController();

			SA_MBA_Jumping.SA_LFS_JumpingController();

			SA_MBA_Turning.SA_LFS_TurningController();	

			SA_MBA_Strafe.SA_LFS_StrafingController();
		}
	}
}