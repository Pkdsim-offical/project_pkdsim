using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations
{
	public class Hatterene_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private HAT_LFS_Jumping Hatterene_MBA_Jumping;
		
		private HAT_LFS_Running Hatterene_MBA_Running;


		private HAT_LFS_Turning Hatterene_MBA_Turning;

		private HAT_LFS_Strafing Hatterene_MBA_Strafe;

		public void HAT_LFS_MovementAnimatorController()
		{
			Hatterene_MBA_Running.HAT_LFS_RunningController();

			Hatterene_MBA_Jumping.HAT_LFS_JumpingController();

			Hatterene_MBA_Turning.HAT_LFS_TurningController();	

			Hatterene_MBA_Strafe.HAT_LFS_StrafingController();
		}
	}
}