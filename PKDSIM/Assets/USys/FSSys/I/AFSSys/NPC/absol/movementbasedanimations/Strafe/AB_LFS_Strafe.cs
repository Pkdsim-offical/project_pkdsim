using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.movementbasedanimations.Strafe
{
	public class AB_LFS_Strafing : MonoBehaviour 
	{
		private AB_LFS_StrafeLeft AB_strafeleft;
		
		private AB_LFS_StrafeRight AB_straferight;

		public void AB_LFS_StrafingController()
		{
			if (AB_strafeleft == null)
			{
				AB_strafeleft = GetComponent<AB_LFS_StrafeLeft>();
				Load_AB_LFS_StrafeLeft();
			}
			if (AB_straferight == null)
			{
				AB_straferight = GetComponent<AB_LFS_StrafeRight>();
				Load_AB_LFS_StrafeRight();
			}
			

		}
		private void Load_AB_LFS_StrafeRight()
		{
			AB_straferight.AB_LFS_StrafeRightController();
		}
		
		private void Load_AB_LFS_StrafeLeft()
		{
			AB_strafeleft.AB_LFS_StrafeLeftController();
		}
	}
}