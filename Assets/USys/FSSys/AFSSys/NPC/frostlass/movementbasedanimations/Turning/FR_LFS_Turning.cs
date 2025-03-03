using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Turning
{
	public class FR_LFS_Turning : MonoBehaviour	
	{
		private FR_LFS_TurnLeft FR_LFS_turnleft;
		private FR_LFS_TurnRIght FR_LFS_turnright;

		public void FR_LFS_TurningController()
		{
			if (FR_LFS_turnleft == null)
			{
				FR_LFS_turnleft = GetComponent<FR_LFS_TurnLeft>();
				Load_FR_turnLeft();
			}
			if (FR_LFS_turnright == null)
			{
				FR_LFS_turnright = GetComponent<FR_LFS_TurnRIght>();
				Load_FR_turnRight();
			}
			

		}
		private void Load_FR_turnRight()
		{
			FR_LFS_turnright.FR_LFS_TurnRightController();
		}
		
		private void Load_FR_turnLeft()
		{
			FR_LFS_turnleft.FR_LFS_TurnLeftController();
		}
	}
}