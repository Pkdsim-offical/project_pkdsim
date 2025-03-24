using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Turning
{
	public class DR_LFS_Turning : MonoBehaviour	
	{
		private DR_LFS_TurnLeft DR_LFS_turnleft;
		private DR_LFS_TurnRIght DR_LFS_turnright;

		public void DR_LFS_TurningController()
		{
			if (DR_LFS_turnleft == null)
			{
				DR_LFS_turnleft = GetComponent<DR_LFS_TurnLeft>();
				Load_DR_turnLeft();
			}
			if (DR_LFS_turnright == null)
			{
				DR_LFS_turnright = GetComponent<DR_LFS_TurnRIght>();
				Load_DR_turnRight();
			}
			

		}
		private void Load_DR_turnRight()
		{
			DR_LFS_turnright.DR_LFS_TurnRightController();
		}
		
		private void Load_DR_turnLeft()
		{
			DR_LFS_turnleft.DR_LFS_TurnLeftController();
		}
	}
}