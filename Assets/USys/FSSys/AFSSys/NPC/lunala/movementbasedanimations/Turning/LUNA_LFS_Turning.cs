using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Turning
{
	public class LUNA_LFS_Turning : MonoBehaviour	
	{
		private LUNA_LFS_TurnLeft LUNA_LFS_turnleft;
		private LUNA_LFS_TurnRIght LUNA_LFS_turnright;

		public void LUNA_LFS_TurningController()
		{
			if (LUNA_LFS_turnleft == null)
			{

				Load_LUNA_turnLeft();
			}

			if (LUNA_LFS_turnright == null)
			{
				Load_LUNA_turnRight();
			}
			

		}
		private void Load_LUNA_turnRight()
		{
			LUNA_LFS_turnright.LUNA_LFS_TurnRightController();
		}
		
		private void Load_LUNA_turnLeft()
		{
			LUNA_LFS_turnleft.LUNA_LFS_TurnLeftController();
		}
	}
}