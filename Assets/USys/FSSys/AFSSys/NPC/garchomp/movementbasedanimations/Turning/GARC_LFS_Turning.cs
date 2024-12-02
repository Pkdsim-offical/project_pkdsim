using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.movementbasedanimations.Turning
{
	public class GARC_LFS_Turning : MonoBehaviour	
	{
		private GARC_LFS_TurnLeft GARC_LFS_turnleft;
		private GARC_LFS_TurnRIght GARC_LFS_turnright;

		public void GARC_LFS_TurningController()
		{
			if (GARC_LFS_turnleft == null)
			{
				GARC_LFS_turnleft = GetComponent<GARC_LFS_TurnLeft>();
				Load_GARC_turnLeft();
			}
			if (GARC_LFS_turnright == null)
			{
				GARC_LFS_turnright = GetComponent<GARC_LFS_TurnRIght>();
				Load_GARC_turnRight();
			}
			

		}
		private void Load_GARC_turnRight()
		{
			GARC_LFS_turnright.GARC_LFS_TurnRightController();
		}
		
		private void Load_GARC_turnLeft()
		{
			GARC_LFS_turnleft.GARC_LFS_TurnLeftController();
		}
	}
}