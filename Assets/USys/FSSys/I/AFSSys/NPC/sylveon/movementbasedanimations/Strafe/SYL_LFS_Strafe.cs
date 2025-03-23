using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.movementbasedanimations.Strafe
{
	public class SYL_LFS_Strafing : MonoBehaviour 
	{
		private SYL_LFS_StrafeLeft SYL_strafeleft;
		
		private SYL_LFS_StrafeRight SYL_straferight;

		public void SYL_LFS_StrafingController()
		{
			if (SYL_strafeleft == null)
			{
				SYL_strafeleft = GetComponent<SYL_LFS_StrafeLeft>();
				Load_SYL_LFS_StrafeLeft();
			}
			if (SYL_straferight == null)
			{
				SYL_straferight = GetComponent<SYL_LFS_StrafeRight>();
				Load_SYL_LFS_StrafeRight();
			}
			

		}
		private void Load_SYL_LFS_StrafeRight()
		{
			SYL_strafeleft.SYL_LFS_StrafeLeftController();
		}
		
		private void Load_SYL_LFS_StrafeLeft()
		{
			SYL_straferight.SYL_LFS_StrafeRightController();
		}
	}
}