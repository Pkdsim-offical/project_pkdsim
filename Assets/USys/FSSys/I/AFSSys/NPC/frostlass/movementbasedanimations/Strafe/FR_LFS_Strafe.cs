using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.movementbasedanimations.Strafe
{
	public class FR_LFS_Strafing : MonoBehaviour 
	{
		private FR_LFS_StrafeLeft FR_strafeleft;
		
		private FR_LFS_StrafeRight FR_straferight;

		public void FR_LFS_StrafingController()
		{
			if (FR_strafeleft == null)
			{
				FR_strafeleft = GetComponent<FR_LFS_StrafeLeft>();
				Load_FR_LFS_StrafeLeft();
			}
			if (FR_straferight == null)
			{
				FR_straferight = GetComponent<FR_LFS_StrafeRight>();
				Load_FR_LFS_StrafeRight();
			}
			

		}
		private void Load_FR_LFS_StrafeRight()
		{
			FR_straferight.FR_LFS_StrafeRightController();
		}
		
		private void Load_FR_LFS_StrafeLeft()
		{
			FR_strafeleft.FR_LFS_StrafeLeftController();
		}
	}
}