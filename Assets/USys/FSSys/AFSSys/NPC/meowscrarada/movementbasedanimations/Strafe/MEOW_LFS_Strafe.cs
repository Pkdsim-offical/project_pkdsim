using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.movementbasedanimations.Strafe
{
	public class MEOW_LFS_Strafing : MonoBehaviour 
	{
		private MEOW_LFS_StrafeLeft MEOW_strafeleft;
		
		private MEOW_LFS_StrafeRight MEOW_straferight;

		public void MEOW_LFS_StrafingController()
		{
			if (MEOW_strafeleft == null)
			{
				MEOW_strafeleft = GetComponent<MEOW_LFS_StrafeLeft>();
				Load_MEOW_LFS_StrafeLeft();
			}
			if (MEOW_straferight == null)
			{
				MEOW_straferight = GetComponent<MEOW_LFS_StrafeRight>();
				Load_MEOW_LFS_StrafeRight();
			}
			

		}
		private void Load_MEOW_LFS_StrafeRight()
		{
			MEOW_straferight.MEOW_LFS_StrafeRightController();
		}
		
		private void Load_MEOW_LFS_StrafeLeft()
		{
			MEOW_strafeleft.MEOW_LFS_StrafeLeftController();
		}
	}
}