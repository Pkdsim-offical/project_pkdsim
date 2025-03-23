using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.movementbasedanimations.Strafe
{
	public class BR_LFS_Strafing : MonoBehaviour 
	{
		private BR_LFS_StrafeLeft BR_strafeleft;
		
		private BR_LFS_StrafeRight BR_straferight;

		public void BR_LFS_StrafingController()
		{
			if (BR_strafeleft == null)
			{
				BR_strafeleft = GetComponent<BR_LFS_StrafeLeft>();
				Load_BR_LFS_StrafeLeft();
			}
			if (BR_straferight == null)
			{
				BR_straferight = GetComponent<BR_LFS_StrafeRight>();
				Load_BR_LFS_StrafeRight();
			}
			

		}
		private void Load_BR_LFS_StrafeRight()
		{
			BR_straferight.BR_LFS_StrafeRightController();
		}
		
		private void Load_BR_LFS_StrafeLeft()
		{
			BR_strafeleft.BR_LFS_StrafeLeftController();
		}
	}
}