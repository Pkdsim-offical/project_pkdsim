using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.movementbasedanimations.Strafe
{
	public class LO_LFS_Strafing : MonoBehaviour 
	{
		private LO_LFS_StrafeLeft LO_strafeleft;
		
		private LO_LFS_StrafeRight LO_straferight;

		public void LO_LFS_StrafingController()
		{
			if (LO_strafeleft == null)
			{
				LO_strafeleft = GetComponent<LO_LFS_StrafeLeft>();
				Load_LO_LFS_StrafeLeft();
			}
			if (LO_straferight == null)
			{
				LO_straferight = GetComponent<LO_LFS_StrafeRight>();
				Load_LO_LFS_StrafeRight();
			}
			

		}
		private void Load_LO_LFS_StrafeRight()
		{
			LO_straferight.LO_LFS_StrafeRightController();
		}
		
		private void Load_LO_LFS_StrafeLeft()
		{
			LO_strafeleft.LO_LFS_StrafeLeftController();
		}
	}
}