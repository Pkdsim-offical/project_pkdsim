using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Turning
{
	public class JT_LFS_Turning : MonoBehaviour	
	{
		JT_LFS_TurnLeft JT_LFS_turnleft;
		JT_LFS_TurnRIght JT_LFS_turnright;

		public void JT_LFS_TurningController()
		{
			if (JT_LFS_turnleft != null)
			{
				Load_JT_turnLeft();
			}

			if (JT_LFS_turnright != null)
			{

				Load_JT_turnRight();
			}
			
		}
		private void Load_JT_turnRight()
		{
			JT_LFS_turnright.JT_LFS_TurnRightController();
		}
		
		private void Load_JT_turnLeft()
		{
			JT_LFS_turnleft.JT_LFS_TurnLeftController();
		}
	}
}