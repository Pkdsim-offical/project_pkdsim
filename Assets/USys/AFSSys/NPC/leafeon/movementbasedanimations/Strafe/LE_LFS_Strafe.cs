using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafe
{
	public class LE_LFS_Strafing : MonoBehaviour 
	{
		private LE_LFS_StrafeLeft LE_strafeleft;
	
		private LE_LFS_StrafeRight LE_straferight;

		public void LE_LFS_StrafingController()
		{
			if (LE_strafeleft == null)
			{
				LE_strafeleft = GetComponent<LE_LFS_StrafeLeft>();
				Load_LE_LFS_StrafeLeft();
			}
			if (LE_straferight == null)
			{
				LE_straferight = GetComponent<LE_LFS_StrafeRight>();
				Load_LE_LFS_StrafeRight();
			}			
		}
		private void Load_LE_LFS_StrafeRight()
		{
			LE_strafeleft.LE_LFS_StrafeLeftController();
		}
		
		private void Load_LE_LFS_StrafeLeft()
		{
			LE_straferight.LE_LFS_StrafeRightController();
		}
	}
}