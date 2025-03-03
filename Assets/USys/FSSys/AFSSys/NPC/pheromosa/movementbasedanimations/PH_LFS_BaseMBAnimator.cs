using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Jumping;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Running;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Strafe;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations
{
	public class Pheromosa_LFS_AnimatorBaseMovementController : MonoBehaviour 
	{
		private PH_LFS_Jumping Pheromosa_MBA_Jumping;
		
		private PH_LFS_Running Pheromosa_MBA_Running;


		private PH_LFS_Turning Pheromosa_MBA_Turning;

		private PH_LFS_Strafing Pheromosa_MBA_Strafe;

		public void PH_LFS_MovementAnimatorController()
		{
			Pheromosa_MBA_Running.PH_LFS_RunningController();

			Pheromosa_MBA_Jumping.PH_LFS_JumpingController();

			Pheromosa_MBA_Turning.PH_LFS_TurningController();	

			Pheromosa_MBA_Strafe.PH_LFS_StrafingController();
		}
	}
}