using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.movementbasedanimations.Strafe
{
	public class C_LFS_Strafing : MonoBehaviour 
	{
		private C_LFS_StrafeLeft C_strafeleft;
		
		private C_LFS_StrafeRight C_straferight;

		public void C_LFS_StrafingController()
		{
			if (C_strafeleft == null)
			{
				C_strafeleft = GetComponent<C_LFS_StrafeLeft>();
				Load_C_LFS_StrafeLeft();
			}
			if (C_straferight == null)
			{
				C_straferight = GetComponent<C_LFS_StrafeRight>();
				Load_C_LFS_StrafeRight();
			}
			

		}
		private void Load_C_LFS_StrafeRight()
		{
			C_straferight.C_LFS_StrafeRightController();
		}
		
		private void Load_C_LFS_StrafeLeft()
		{
			C_strafeleft.C_LFS_StrafeLeftController();
		}
	}
}