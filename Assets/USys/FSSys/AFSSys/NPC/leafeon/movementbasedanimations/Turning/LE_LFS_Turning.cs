using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning.TurnLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning.TurnRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Turning
{
	public class LE_LFS_Turning : MonoBehaviour	
	{
		LE_LFS_TurnLeft LEAF_LFS_turnleft;

		LE_LFS_TurnRIght LEAF_LFS_turnright;

		public void LE_LFS_TurningController()
		{
			if (LEAF_LFS_turnleft != null)
			{
				Load_LEAF_turnLeft();
			}

			if (LEAF_LFS_turnright != null)
			{

				Load_LEAF_turnRight();
			}
			
		}
		private void Load_LEAF_turnRight()
		{
			LEAF_LFS_turnright.LE_LFS_TurnRightController();
		}
		
		private void Load_LEAF_turnLeft()
		{
			LEAF_LFS_turnleft.LE_LFS_TurnLeftController();
		}
	}
}