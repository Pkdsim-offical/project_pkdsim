using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Turning
{
	public class BL_LFS_Turning : MonoBehaviour	
	{
		BL_LFS_TurnLeft BL_LFS_turnleft;
		BL_LFS_TurnRIght BL_LFS_turnright;

		public void BL_LFS_TurningController()
		{
			if (BL_LFS_turnleft == null)
			{
				BL_LFS_turnleft = GetComponent<BL_LFS_TurnLeft>();
				Load_BL_turnLeft();
			}
			if (BL_LFS_turnright == null)
			{
				BL_LFS_turnright = GetComponent<BL_LFS_TurnRIght>();
				Load_BL_turnRight();
			}
			

		}
		private void Load_BL_turnRight()
		{
			BL_LFS_turnright.BL_LFS_TurnRightController();
		}
		
		private void Load_BL_turnLeft()
		{
			BL_LFS_turnleft.BL_LFS_TurnLeftController();
		}
	}
}