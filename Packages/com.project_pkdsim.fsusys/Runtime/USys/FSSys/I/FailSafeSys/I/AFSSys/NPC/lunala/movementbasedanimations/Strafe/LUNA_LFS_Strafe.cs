using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.movementbasedanimations.Strafing
{
	public class LUNA_LFS_Strafing : MonoBehaviour 
	{
		private LUNA_LFS_StrafeLeft LUNA_strafeleft;
		
		private LUNA_LFS_StrafeRight LUNA_straferight;

		public void LUNA_LFS_StrafingController()
		{
			if (LUNA_strafeleft == null)
			{
				LUNA_strafeleft = GetComponent<LUNA_LFS_StrafeLeft>();
				Load_LUNA_LFS_StrafeLeft();
			}
			if (LUNA_straferight == null)
			{
				LUNA_straferight = GetComponent<LUNA_LFS_StrafeRight>();
				Load_LUNA_LFS_StrafeRight();
			}
			

		}
		private void Load_LUNA_LFS_StrafeRight()
		{
			LUNA_straferight.LUNA_LFS_StrafeRightController();
		}
		
		private void Load_LUNA_LFS_StrafeLeft()
		{
			LUNA_strafeleft.LUNA_LFS_StrafeLeftController();
		}
	}
}