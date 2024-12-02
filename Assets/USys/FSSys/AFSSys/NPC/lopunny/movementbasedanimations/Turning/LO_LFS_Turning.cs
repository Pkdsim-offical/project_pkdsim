using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Turning
{
	public class LO_LFS_Turning : MonoBehaviour	
	{
		private LO_LFS_TurnLeft LO_LFS_turnleft;
		private LO_LFS_TurnRIght LO_LFS_turnright;

		public void LO_LFS_TurningController()
		{
			if (LO_LFS_turnleft == null)
			{
				Load_LO_turnLeft();
			}

			if (LO_LFS_turnright == null)
			{

				Load_LO_turnRight();
			}
			
		}
		private void Load_LO_turnRight()
		{
			LO_LFS_turnright.LO_LFS_TurnRightController();
		}
		
		private void Load_LO_turnLeft()
		{
			LO_LFS_turnleft.LO_LFS_TurnLeftController();
		}
	}
}