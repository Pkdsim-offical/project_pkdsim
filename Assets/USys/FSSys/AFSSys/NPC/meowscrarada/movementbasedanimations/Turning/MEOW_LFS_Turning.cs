using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Turning
{
	public class MEOW_LFS_Turning : MonoBehaviour	
	{
		MEOW_LFS_TurnLeft MEOW_LFS_turnleft;
		MEOW_LFS_TurnRIght MEOW_LFS_turnright;

		public void MEOW_LFS_TurningController()
		{
			if (MEOW_LFS_turnleft == null)
			{
				MEOW_LFS_turnleft = GetComponent<MEOW_LFS_TurnLeft>();
				Load_MEOW_turnLeft();
			}
			if (MEOW_LFS_turnright == null)
			{
				MEOW_LFS_turnright = GetComponent<MEOW_LFS_TurnRIght>();
				Load_MEOW_turnRight();
			}
			

		}
		private void Load_MEOW_turnRight()
		{
			MEOW_LFS_turnright.MEOW_LFS_TurnRightController();
		}
		
		private void Load_MEOW_turnLeft()
		{
			MEOW_LFS_turnleft.MEOW_LFS_TurnLeftController();
		}
	}
}