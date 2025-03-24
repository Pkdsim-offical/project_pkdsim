using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.movementbasedanimations.Turning
{
	public class PH_LFS_Turning : MonoBehaviour	
	{
		PH_LFS_TurnLeft PH_LFS_turnleft;
		PH_LFS_TurnRIght PH_LFS_turnright;

		public void PH_LFS_TurningController()
		{
			if (PH_LFS_turnleft != null)
			{
				Load_PH_turnLeft();
			}
			
			if (PH_LFS_turnright != null)
			{
				Load_PH_turnRight();
			}
			

		}
		private void Load_PH_turnRight()
		{
			PH_LFS_turnright.PH_LFS_TurnRightController();
		}
		
		private void Load_PH_turnLeft()
		{
			PH_LFS_turnleft.PH_LFS_TurnLeftController();
		}
	}
}