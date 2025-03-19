using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.movementbasedanimations.Strafe
{
	public class GARD_LFS_Strafing : MonoBehaviour 
	{
		private GARD_LFS_StrafeLeft GARD_strafeleft;
		
		private GARD_LFS_StrafeRight GARD_straferight;

		public void GARD_LFS_StrafingController()
		{
			if (GARD_strafeleft == null)
			{
				Load_GARD_LFS_StrafeLeft();
			}
			if (GARD_straferight == null)
			{
				Load_GARD_LFS_StrafeRight();
			}
			

		}
		private void Load_GARD_LFS_StrafeRight()
		{
			GARD_straferight.GARD_LFS_StrafeRightController();
		}
		
		private void Load_GARD_LFS_StrafeLeft()
		{
			GARD_strafeleft.GARD_LFS_StrafeLeftController();
		}
	}
}