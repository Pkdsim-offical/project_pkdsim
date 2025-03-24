using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Turning
{
	public class DL_LFS_Turning : MonoBehaviour	
	{
		DL_LFS_TurnLeft DL_LFS_turnleft;
		DL_LFS_TurnRIght DL_LFS_turnright;

		public void DL_LFS_TurningController()
		{
			if (DL_LFS_turnleft == null)
			{
				DL_LFS_turnleft = GetComponent<DL_LFS_TurnLeft>();
				Load_DL_turnLeft();
			}
			if (DL_LFS_turnright == null)
			{
				DL_LFS_turnright = GetComponent<DL_LFS_TurnRIght>();
				Load_DL_turnRight();
			}
			

		}
		private void Load_DL_turnRight()
		{
			DL_LFS_turnright.DL_LFS_TurnRightController();
		}
		
		private void Load_DL_turnLeft()
		{
			DL_LFS_turnleft.DL_LFS_TurnLeftController();
		}
	}
}