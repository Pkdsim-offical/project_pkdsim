using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Blaziken.movementbasedanimations.Strafe
{
	public class BL_LFS_Strafing : MonoBehaviour 
	{
		private BL_LFS_StrafeLeft BL_strafeleft;
		
		private BL_LFS_StrafeRight BL_straferight;

		public void BL_LFS_StrafingController()
		{
			if (BL_strafeleft == null)
			{
				BL_strafeleft = GetComponent<BL_LFS_StrafeLeft>();
				Load_BL_LFS_StrafeLeft();
			}
			if (BL_straferight == null)
			{
				BL_straferight = GetComponent<BL_LFS_StrafeRight>();
				Load_BL_LFS_StrafeRight();
			}
			

		}
		private void Load_BL_LFS_StrafeRight()
		{
			BL_straferight.BL_LFS_StrafeRightController();
		}
		
		private void Load_BL_LFS_StrafeLeft()
		{
			BL_strafeleft.BL_LFS_StrafeLeftController();
		}
	}
}