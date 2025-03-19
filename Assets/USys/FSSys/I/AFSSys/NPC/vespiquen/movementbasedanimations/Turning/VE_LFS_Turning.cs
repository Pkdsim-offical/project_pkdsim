using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Turning
{
	public class VE_LFS_Turning : MonoBehaviour	
	{
		VE_LFS_TurnLeft VE_LFS_turnleft;
		VE_LFS_TurnRIght VE_LFS_turnright;

		public void VE_LFS_TurningController()
		{
			if (VE_LFS_turnleft != null)
			{
				
				Load_Ve_turnLeft();
			}

			if (VE_LFS_turnright != null)
			{
				Load_Ve_turnRight();
			}
			
		}
		private void Load_Ve_turnRight()
		{
			VE_LFS_turnright.VE_LFS_TurnRightController();
		}
		
		private void Load_Ve_turnLeft()
		{
			VE_LFS_turnleft.VE_LFS_TurnLeftController();
		}
	}
}