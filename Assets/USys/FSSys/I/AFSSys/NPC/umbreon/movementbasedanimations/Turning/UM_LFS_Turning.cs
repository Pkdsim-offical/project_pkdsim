using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Turning
{
	public class UM_LFS_Turning : MonoBehaviour	
	{
		UM_LFS_TurnLeft UM_LFS_turnleft;
		UM_LFS_TurnRIght UM_LFS_turnright;

		public void UM_LFS_TurningController()
		{
			if (UM_LFS_turnleft != null)
			{
				Load_UM_turnLeft();
			}
			
			if (UM_LFS_turnright != null)
			{
				Load_UM_turnRight();
			}
			
		}
		private void Load_UM_turnRight()
		{
			UM_LFS_turnright.UM_LFS_TurnRightController();
		}
		
		private void Load_UM_turnLeft()
		{
			UM_LFS_turnleft.UM_LFS_TurnLeftController();
		}
	}
}