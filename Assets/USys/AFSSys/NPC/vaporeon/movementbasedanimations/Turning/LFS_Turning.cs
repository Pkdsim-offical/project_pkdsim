using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Turning
{
	public class VP_LFS_Turning : MonoBehaviour 
	{
		VP_LFS_TurnLeft VP_LFS_turnleft;
		VP_LFS_TurnRIght VP_LFS_turnright;

		public void VP_LFS_TurningController()
		{
			if (VP_LFS_turnleft == null)
			{
				VP_LFS_turnleft = GetComponent<VP_LFS_TurnLeft>();
				Load_VP_turnLeft();
			}
			if (VP_LFS_turnright == null)
			{
				VP_LFS_turnright = GetComponent<VP_LFS_TurnRIght>();
				Load_VP_turnRight();
			}
			

		}
		private void Load_VP_turnRight()
		{
			VP_LFS_turnright.VP_LFS_TurnRightController();
		}
		
		private void Load_VP_turnLeft()
		{
			VP_LFS_turnleft.VP_LFS_TurnLeftController();
		}
	}
}