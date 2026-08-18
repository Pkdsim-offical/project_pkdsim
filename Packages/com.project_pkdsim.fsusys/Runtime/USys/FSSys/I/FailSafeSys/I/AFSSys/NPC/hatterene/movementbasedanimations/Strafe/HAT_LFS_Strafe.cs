using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.movementbasedanimations.Strafing
{
	public class HAT_LFS_Strafing : MonoBehaviour 
	{
		private HAT_LFS_StrafeLeft HAT_strafeleft;
		
		private HAT_LFS_StrafeRight HAT_straferight;

		public void HAT_LFS_StrafingController()
		{
			if (HAT_strafeleft == null)
			{
				HAT_strafeleft = GetComponent<HAT_LFS_StrafeLeft>();
				Load_HAT_LFS_StrafeLeft();
			}
			if (HAT_straferight == null)
			{
				HAT_straferight = GetComponent<HAT_LFS_StrafeRight>();
				Load_HAT_LFS_StrafeRight();
			}
			

		}
		private void Load_HAT_LFS_StrafeRight()
		{
			HAT_straferight.HAT_LFS_StrafeRightController();
		}
		
		private void Load_HAT_LFS_StrafeLeft()
		{
			HAT_strafeleft.HAT_LFS_StrafeLeftController();
		}
	}
}