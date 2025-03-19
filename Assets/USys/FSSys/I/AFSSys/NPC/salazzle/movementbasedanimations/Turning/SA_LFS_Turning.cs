using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Turning
{
	public class SA_LFS_Turning : MonoBehaviour	
	{
		SA_LFS_TurnLeft SA_LFS_turnleft;
		SA_LFS_TurnRIght SA_LFS_turnright;

		public void SA_LFS_TurningController()
		{
			if (SA_LFS_turnleft != null)
			{
				Load_T_turnLeft();
			}

			if (SA_LFS_turnright != null)
			{
				Load_T_turnRight();
			}
		}
		private void Load_T_turnRight()
		{
			SA_LFS_turnright.SA_LFS_TurnRightController();
		}
		
		private void Load_T_turnLeft()
		{
			SA_LFS_turnleft.SA_LFS_TurnLeftController();
		}
	}
}