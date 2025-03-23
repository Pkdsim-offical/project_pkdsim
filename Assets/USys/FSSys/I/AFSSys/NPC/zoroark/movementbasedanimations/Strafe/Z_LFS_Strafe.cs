using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.movementbasedanimations.Strafe
{
	public class Z_LFS_Strafing : MonoBehaviour 
	{
		private Z_LFS_StrafeLeft Z_strafeleft;
		
		private Z_LFS_StrafeRight Z_straferight;

		public void Z_LFS_StrafingController()
		{
			if (Z_strafeleft == null)
			{
				Z_strafeleft = GetComponent<Z_LFS_StrafeLeft>();
				Load_Z_LFS_StrafeLeft();
			}
			if (Z_straferight == null)
			{
				Z_straferight = GetComponent<Z_LFS_StrafeRight>();
				Load_Z_LFS_StrafeRight();
			}
			

		}
		private void Load_Z_LFS_StrafeRight()
		{
			Z_straferight.Z_LFS_StrafeRightController();
		}
		
		private void Load_Z_LFS_StrafeLeft()
		{
			Z_strafeleft.Z_LFS_StrafeLeftController();
		}
	}
}