using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Turning
{
	public class HAT_LFS_Turning : MonoBehaviour	
	{
		private HAT_LFS_TurnLeft HAT_LFS_turnleft;
		private HAT_LFS_TurnRIght HAT_LFS_turnright;

		public void HAT_LFS_TurningController()
		{
			if (HAT_LFS_turnleft == null)
			{
				HAT_LFS_turnleft = GetComponent<HAT_LFS_TurnLeft>();
				Load_HAT_turnLeft();
			}
			if (HAT_LFS_turnright == null)
			{
				HAT_LFS_turnright = GetComponent<HAT_LFS_TurnRIght>();
				Load_HAT_turnRight();
			}
			

		}
		private void Load_HAT_turnRight()
		{
			HAT_LFS_turnright.HAT_LFS_TurnRightController();
		}
		
		private void Load_HAT_turnLeft()
		{
			HAT_LFS_turnleft.HAT_LFS_TurnLeftController();
		}
	}
}