using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations.Turning;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations.Running;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations.Strafe;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.movementbasedanimations
{
	public class Umbreon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private UM_Jumping UM_MBA_Jumping;
		
		private UM_Running UM_MBA_Running;

		private UM_Turning UM_MBA_Turning;

		private UM_Strafing UM_MBA_Strafe;

		private void UM_MovementAnimatorController()
		{
			UM_MBA_Running.UM_RunningController();

			UM_MBA_Jumping.UM_JumpingController();

			UM_MBA_Turning.UM_TurningController();	

			UM_MBA_Strafe.UM_StrafingController();
		}	
	}
}