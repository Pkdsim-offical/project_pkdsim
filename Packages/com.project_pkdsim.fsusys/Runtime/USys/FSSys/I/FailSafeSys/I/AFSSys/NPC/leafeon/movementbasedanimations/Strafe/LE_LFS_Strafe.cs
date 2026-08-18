using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations.Strafing
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