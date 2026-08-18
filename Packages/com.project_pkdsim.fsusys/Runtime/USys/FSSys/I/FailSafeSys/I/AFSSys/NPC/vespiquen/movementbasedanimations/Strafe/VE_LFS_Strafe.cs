using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.movementbasedanimations.Strafing
{
	public class VE_LFS_Strafing : MonoBehaviour 
	{
		private VE_LFS_StrafeLeft VE_strafeleft;
		
		private VE_LFS_StrafeRight VE_straferight;

		public void VE_LFS_StrafingController()
		{
			if (VE_strafeleft == null)
			{
				VE_strafeleft = GetComponent<VE_LFS_StrafeLeft>();
				Load_VE_LFS_StrafeLeft();
			}
			if (VE_straferight == null)
			{
				VE_straferight = GetComponent<VE_LFS_StrafeRight>();
				Load_VE_LFS_StrafeRight();
			}
			

		}
		private void Load_VE_LFS_StrafeRight()
		{
			VE_straferight.VE_LFS_StrafeRightController();
		}
		
		private void Load_VE_LFS_StrafeLeft()
		{
			VE_strafeleft.VE_LFS_StrafeLeftController();
		}
	}
}