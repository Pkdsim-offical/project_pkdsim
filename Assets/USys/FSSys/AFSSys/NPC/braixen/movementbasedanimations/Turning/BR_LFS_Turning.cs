using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Turning
{
	public class BR_LFS_Turning : MonoBehaviour	
	{
		BR_LFS_TurnLeft BR_LFS_turnleft;
		BR_LFS_TurnRIght BR_LFS_turnright;

		public void BR_LFS_TurningController()
		{
			if (BR_LFS_turnleft == null)
			{
				BR_LFS_turnleft = GetComponent<BR_LFS_TurnLeft>();
				Load_BR_turnLeft();
			}
			if (BR_LFS_turnright == null)
			{
				BR_LFS_turnright = GetComponent<BR_LFS_TurnRIght>();
				Load_BR_turnRight();
			}
			

		}
		private void Load_BR_turnRight()
		{
			BR_LFS_turnright.BR_LFS_TurnRightController();
		}
		
		private void Load_BR_turnLeft()
		{
			BR_LFS_turnleft.BR_LFS_TurnLeftController();
		}
	}
}