using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Turning
{
	public class PR_LFS_Turning : MonoBehaviour	
	{
		PR_LFS_TurnLeft PR_LFS_turnleft;
		PR_LFS_TurnRIght PR_LFS_turnright;

		public void PR_LFS_TurningController()
		{
			if (PR_LFS_turnleft != null)
			{
				Load_PR_turnLeft();
			}

			if (PR_LFS_turnright != null)
			{
				Load_PR_turnRight();
			}
			
		}
		private void Load_PR_turnRight()
		{
			PR_LFS_turnright.PR_LFS_TurnRightController();
		}
		
		private void Load_PR_turnLeft()
		{
			PR_LFS_turnleft.PR_LFS_TurnLeftController();
		}
	}
}