using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Turning
{
	public class GARD_LFS_Turning : MonoBehaviour	
	{
		private GARD_LFS_TurnLeft GARD_LFS_turnleft;
		private GARD_LFS_TurnRIght GARD_LFS_turnright;

		public void GARD_LFS_TurningController()
		{
			if (GARD_LFS_turnleft == null)
			{
				GARD_LFS_turnleft = GetComponent<GARD_LFS_TurnLeft>();
				Load_GARD_turnLeft();
			}
			if (GARD_LFS_turnright == null)
			{
				GARD_LFS_turnright = GetComponent<GARD_LFS_TurnRIght>();
				Load_GARD_turnRight();
			}
			

		}
		private void Load_GARD_turnRight()
		{
			GARD_LFS_turnright.GARD_LFS_TurnRightController();
		}
		
		private void Load_GARD_turnLeft()
		{
			GARD_LFS_turnleft.GARD_LFS_TurnLeftController();
		}
	}
}