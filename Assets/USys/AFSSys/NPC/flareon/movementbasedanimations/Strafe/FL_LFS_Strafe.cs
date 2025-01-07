using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.espeon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.espeon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.movementbasedanimations.Strafe
{
	public class FL_LFS_Strafing : MonoBehaviour 
	{
		private FL_LFS_StrafeLeft FL_strafeleft;
		
		private FL_LFS_StrafeRight FL_straferight;

		public void FL_LFS_StrafingController()
		{
			if (FL_strafeleft == null)
			{
				FL_strafeleft = GetComponent<FL_LFS_StrafeLeft>();
				Load_FL_LFS_StrafeLeft();
			}
			if (FL_straferight == null)
			{
				FL_straferight = GetComponent<FL_LFS_StrafeRight>();
				Load_FL_LFS_StrafeRight();
			}
			

		}
		private void Load_FL_LFS_StrafeRight()
		{
			FL_straferight.FL_LFS_StrafeRightController();
		}
		
		private void Load_FL_LFS_StrafeLeft()
		{
			FL_strafeleft.FL_LFS_StrafeLeftController();
		}
	}
}