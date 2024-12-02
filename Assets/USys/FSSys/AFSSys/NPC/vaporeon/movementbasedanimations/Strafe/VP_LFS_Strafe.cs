using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Strafe.StrafeRight;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Strafe.StrafeLeft;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations.Strafe
{
	public class VP_LFS_Strafing : MonoBehaviour 
	{
		private VP_LFS_StrafeLeft VP_strafeleft;
		
		private VP_LFS_StrafeRight VP_straferight;

		public void VP_LFS_StrafingController()
		{
			if (VP_strafeleft == null)
			{
				VP_strafeleft = GetComponent<VP_LFS_StrafeLeft>();
				Load_VP_LFS_StrafeLeft();
			}
			if (VP_straferight == null)
			{
				VP_straferight = GetComponent<VP_LFS_StrafeRight>();
				Load_VP_LFS_StrafeRight();
			}
			

		}
		private void Load_VP_LFS_StrafeRight()
		{
			VP_straferight.VP_LFS_StrafeRightController();
		}
		
		private void Load_VP_LFS_StrafeLeft()
		{
			VP_strafeleft.VP_LFS_StrafeLeftController();
		}
	}
}