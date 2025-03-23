using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations
{
	public class Meowscarada_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private MEOW_LFS_Jumping Meowscarada_MBA_Jumping;
		
		private MEOW_LFS_Running Meowscarada_MBA_Running;


		private MEOW_LFS_Turning Meowscarada_MBA_Turning;

		private MEOW_LFS_Strafing Meowscarada_MBA_Strafe;

		public void MEOW_LFS_MovementAnimatorController()
		{
			Meowscarada_MBA_Running.MEOW_LFS_RunningController();

			Meowscarada_MBA_Jumping.MEOW_LFS_JumpingController();

			Meowscarada_MBA_Turning.MEOW_LFS_TurningController();	

			Meowscarada_MBA_Strafe.MEOW_LFS_StrafingController();
		}
	}
}