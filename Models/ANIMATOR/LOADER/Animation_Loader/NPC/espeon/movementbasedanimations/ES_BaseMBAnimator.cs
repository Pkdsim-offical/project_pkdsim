using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Running;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Strafe;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Jumping;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations.Turning;
using UnityEngine;


namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.movementbasedanimations
{
	public class Espeon_AnimatorBaseMovementController : MonoBehaviour 
	{
		private ES_Jumping ES_MBA_Jumping;
		
		private ES_Running ES_MBA_Running;

		private ES_Turning ES_MBA_Turning;

		private ES_Strafing ES_MBA_Strafe;

		private void ES_BaseIdleAnimatorController()
		{
			ES_MBA_Running.ES_RunningController();

			ES_MBA_Jumping.ES_JumpingController();

			ES_MBA_Turning.ES_TurningController();	

			ES_MBA_Strafe.ES_StrafingController();
		}
	}
}