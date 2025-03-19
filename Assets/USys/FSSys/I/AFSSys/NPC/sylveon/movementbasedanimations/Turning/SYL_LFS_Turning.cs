using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;


namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Turning
{
	public class SYL_LFS_Turning : MonoBehaviour	
	{
		SYL_LFS_TurnLeft SYL_LFS_turnleft;
		SYL_LFS_TurnRIght SYL_LFS_turnright;

		public void SYL_LFS_TurningController()
		{
			if (SYL_LFS_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (SYL_LFS_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			SYL_LFS_turnright.SYL_LFS_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			SYL_LFS_turnleft.SYL_LFS_TurnLeftController();
		}
	}
}