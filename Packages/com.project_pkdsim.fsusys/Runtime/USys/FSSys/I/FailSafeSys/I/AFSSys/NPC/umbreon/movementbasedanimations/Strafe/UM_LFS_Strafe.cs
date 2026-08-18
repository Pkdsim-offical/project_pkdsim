using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.movementbasedanimations.Strafing
{
	public class UM_LFS_Strafing : MonoBehaviour 
	{
		private UM_LFS_StrafeLeft UM_strafeleft;
		
		private UM_LFS_StrafeRight UM_straferight;

		public void UM_LFS_StrafingController()
		{
			if (UM_strafeleft == null)
			{
				UM_strafeleft = GetComponent<UM_LFS_StrafeLeft>();
				Load_UM_LFS_StrafeLeft();
			}
			if (UM_straferight == null)
			{
				UM_straferight = GetComponent<UM_LFS_StrafeRight>();
				Load_UM_LFS_StrafeRight();
			}
			

		}
		private void Load_UM_LFS_StrafeRight()
		{
			UM_strafeleft.UM_LFS_StrafeLeftController();
		}
		
		private void Load_UM_LFS_StrafeLeft()
		{
			UM_straferight.UM_LFS_StrafeRightController();
		}
	}
}