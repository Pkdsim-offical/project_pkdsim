using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations.Turning
{
	public class PL_LFS_Turning : MonoBehaviour	
	{
		PL_LFS_TurnLeft PL_LFS_turnleft;
		PL_LFS_TurnRight PL_LFS_turnright;

		public void PL_LFS_TurningController()
		{
			if (PL_LFS_turnleft == null)
			{
				PL_LFS_turnleft = GetComponent<PL_LFS_TurnLeft>();
				Load_PL_turnLeft();
			}
			if (PL_LFS_turnright == null)
			{
				PL_LFS_turnright = GetComponent<PL_LFS_TurnRight>();
				Load_PL_turnRight();
			}
		}
		private void Load_PL_turnRight()
		{
			PL_LFS_turnright.PL_LFS_TurnRightController();
		}
		
		private void Load_PL_turnLeft()
		{
			PL_LFS_turnleft.PL_LFS_TurnLeftController();
		}
	}
}