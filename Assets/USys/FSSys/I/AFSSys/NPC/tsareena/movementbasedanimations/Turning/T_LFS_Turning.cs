using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Turning
{
	public class T_LFS_Turning : MonoBehaviour	
	{
		private T_LFS_TurnLeft T_LFS_turnleft;
		private T_LFS_TurnRIght T_LFS_turnright;

		public void T_LFS_TurningController()
		{
			if (T_LFS_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (T_LFS_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			T_LFS_turnright.T_LFS_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			T_LFS_turnleft.T_LFS_TurnLeftController();
		}
	}
}