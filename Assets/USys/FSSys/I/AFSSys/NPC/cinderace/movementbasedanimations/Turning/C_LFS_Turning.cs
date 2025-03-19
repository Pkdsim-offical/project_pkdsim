using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Turning
{
	public class C_LFS_Turning : MonoBehaviour	
	{
		private C_LFS_TurnLeft C_LFS_turnleft;
		private C_LFS_TurnRIght C_LFS_turnright;

		public void C_LFS_TurningController()
		{
			if (C_LFS_turnleft == null)
			{
				C_LFS_turnleft = GetComponent<C_LFS_TurnLeft>();
				Load_C_turnLeft();
			}
			if (C_LFS_turnright == null)
			{
				C_LFS_turnright = GetComponent<C_LFS_TurnRIght>();
				Load_C_turnRight();
			}
			

		}
		private void Load_C_turnRight()
		{
			C_LFS_turnright.C_LFS_TurnRightController();
		}
		
		private void Load_C_turnLeft()
		{
			C_LFS_turnleft.C_LFS_TurnLeftController();
		}
	}
}