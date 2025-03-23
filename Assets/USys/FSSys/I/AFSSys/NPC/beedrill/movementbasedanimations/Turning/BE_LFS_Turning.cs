using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Turning
{
	public class BE_LFS_Turning : MonoBehaviour	
	{
		private BE_LFS_TurnLeft BE_LFS_turnleft;
		private BE_LFS_TurnRIght BE_LFS_turnright;

		public void BE_LFS_TurningController()
		{
			if (BE_LFS_turnleft == null)
			{
				BE_LFS_turnleft = GetComponent<BE_LFS_TurnLeft>();
				Load_BE_turnLeft();
			}
			if (BE_LFS_turnright == null)
			{
				BE_LFS_turnright = GetComponent<BE_LFS_TurnRIght>();
				Load_BE_turnRight();
			}
			

		}
		private void Load_BE_turnRight()
		{
			BE_LFS_turnright.BE_LFS_TurnRightController();
		}
		
		private void Load_BE_turnLeft()
		{
			BE_LFS_turnleft.BE_LFS_TurnLeftController();
		}
	}
}