using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations
{
	public class Lopunny_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private LO_LFS_Jumping Lopunny_MBA_Jumping;
		
		private LO_LFS_Running Lopunny_MBA_Running;


		private LO_LFS_Turning Lopunny_MBA_Turning;

		private LO_LFS_Strafing Lopunny_MBA_Strafe;

		public void LO_LFS_MovementAnimatorController()
		{
			Lopunny_MBA_Running.LO_LFS_RunningController();

			Lopunny_MBA_Jumping.LO_LFS_JumpingController();

			Lopunny_MBA_Turning.LO_LFS_TurningController();	

			Lopunny_MBA_Strafe.LO_LFS_StrafingController();
		}
	}
}