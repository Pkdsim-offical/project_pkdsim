using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.movementbasedanimations.Strafe
{
	public class DL_LFS_Strafing : MonoBehaviour 
	{
		private DL_LFS_StrafeLeft DL_strafeleft;
		
		private DL_LFS_StrafeRight DL_straferight;

		public void DL_LFS_StrafingController()
		{
			if (DL_strafeleft == null)
			{
				DL_strafeleft = GetComponent<DL_LFS_StrafeLeft>();
				Load_DL_LFS_StrafeLeft();
			}
			if (DL_straferight == null)
			{
				DL_straferight = GetComponent<DL_LFS_StrafeRight>();
				Load_DL_LFS_StrafeRight();
			}
			

		}
		private void Load_DL_LFS_StrafeRight()
		{
			DL_straferight.DL_LFS_StrafeRightController();
		}
		
		private void Load_DL_LFS_StrafeLeft()
		{
			DL_strafeleft.DL_LFS_StrafeLeftController();
		}
	}
}