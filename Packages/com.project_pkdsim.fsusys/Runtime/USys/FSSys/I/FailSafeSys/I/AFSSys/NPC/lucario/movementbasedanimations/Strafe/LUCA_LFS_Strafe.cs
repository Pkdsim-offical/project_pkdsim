using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.movementbasedanimations.Strafing
{
	public class LUCA_LFS_Strafing : MonoBehaviour 
	{
		private LUCA_LFS_StrafeLeft LUCA_strafeleft;
		
		private LUCA_LFS_StrafeRight LUCA_straferight;

		public void LUCA_LFS_StrafingController()
		{
			if (LUCA_strafeleft == null)
			{
				LUCA_strafeleft = GetComponent<LUCA_LFS_StrafeLeft>();
				Load_LUCA_LFS_StrafeLeft();
			}
			if (LUCA_straferight == null)
			{
				LUCA_straferight = GetComponent<LUCA_LFS_StrafeRight>();
				Load_LUCA_LFS_StrafeRight();
			}
			

		}
		private void Load_LUCA_LFS_StrafeRight()
		{
			LUCA_straferight.LUCA_LFS_StrafeRightController();
		}
		
		private void Load_LUCA_LFS_StrafeLeft()
		{
			LUCA_strafeleft.LUCA_LFS_StrafeLeftController();
		}
	}
}