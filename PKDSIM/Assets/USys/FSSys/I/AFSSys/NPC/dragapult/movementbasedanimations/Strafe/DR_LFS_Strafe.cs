using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.movementbasedanimations.Strafe
{
	public class DR_LFS_Strafing : MonoBehaviour 
	{
		private DR_LFS_StrafeLeft DR_strafeleft;
		
		private DR_LFS_StrafeRight DR_straferight;

		public void DR_LFS_StrafingController()
		{
			if (DR_strafeleft == null)
			{
				DR_strafeleft = GetComponent<DR_LFS_StrafeLeft>();
				Load_DR_LFS_StrafeLeft();
			}
			if (DR_straferight == null)
			{
				DR_straferight = GetComponent<DR_LFS_StrafeRight>();
				Load_DR_LFS_StrafeRight();
			}
			

		}
		private void Load_DR_LFS_StrafeRight()
		{
			DR_straferight.DR_LFS_StrafeRightController();
		}
		
		private void Load_DR_LFS_StrafeLeft()
		{
			DR_strafeleft.DR_LFS_StrafeLeftController();
		}
	}
}