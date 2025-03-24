using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Turning
{
	public class FL_LFS_Turning : MonoBehaviour	
	{
		FL_LFS_TurnLeft FL_LFS_turnleft;
		FL_LFS_TurnRIght FL_LFS_turnright;

		public void FL_LFS_TurningController()
		{
			if (FL_LFS_turnleft == null)
			{
				FL_LFS_turnleft = GetComponent<FL_LFS_TurnLeft>();
				Load_FL_turnLeft();
			}
			if (FL_LFS_turnright == null)
			{
				FL_LFS_turnright = GetComponent<FL_LFS_TurnRIght>();
				Load_FL_turnRight();
			}
			

		}
		private void Load_FL_turnRight()
		{
			FL_LFS_turnright.FL_LFS_TurnRightController();
		}
		
		private void Load_FL_turnLeft()
		{
			FL_LFS_turnleft.FL_LFS_TurnLeftController();
		}
	}
}