using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Turning
{
	public class Z_LFS_Turning : MonoBehaviour	
	{
		Z_LFS_TurnLeft Z_LFS_turnleft;
		Z_LFS_TurnRIght Z_LFS_turnright;

		public void Z_LFS_TurningController()
		{
			if (Z_LFS_turnleft != null)
			{
				Load_Z_turnLeft();
			}
			
			if (Z_LFS_turnright != null)
			{
				Load_Z_turnRight();
			}
		}
		private void Load_Z_turnRight()
		{
			Z_LFS_turnright.Z_LFS_TurnRightController();
		}
		
		private void Load_Z_turnLeft()
		{
			Z_LFS_turnleft.Z_LFS_TurnLeftController();
		}
	}
}