using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.movementbasedanimations.Strafe
{
	public class BE_LFS_Strafing : MonoBehaviour 
	{
		private BE_LFS_StrafeLeft BE_strafeleft;
		
		private BE_LFS_StrafeRight BE_straferight;

		public void BE_LFS_StrafingController()
		{
			if (BE_strafeleft == null)
			{
				BE_strafeleft = GetComponent<BE_LFS_StrafeLeft>();
				Load_BE_LFS_StrafeLeft();
			}
			if (BE_straferight == null)
			{
				BE_straferight = GetComponent<BE_LFS_StrafeRight>();
				Load_BE_LFS_StrafeRight();
			}
			

		}
		private void Load_BE_LFS_StrafeRight()
		{
			BE_straferight.BE_LFS_StrafeRightController();
		}
		
		private void Load_BE_LFS_StrafeLeft()
		{
			BE_strafeleft.BE_LFS_StrafeLeftController();
		}
	}
}