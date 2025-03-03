using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations.Strafe
{
	public class NOI_LFS_Strafing : MonoBehaviour 
	{
		private NOI_LFS_StrafeLeft NOI_strafeleft;
		
		private NOI_LFS_StrafeRight NOI_straferight;

		public void NOI_LFS_StrafingController()
		{
			if (NOI_strafeleft == null)
			{
				NOI_strafeleft = GetComponent<NOI_LFS_StrafeLeft>();
				Load_NOI_LFS_StrafeLeft();
			}
			if (NOI_straferight == null)
			{
				NOI_straferight = GetComponent<NOI_LFS_StrafeRight>();
				Load_NOI_LFS_StrafeRight();
			}
			

		}
		private void Load_NOI_LFS_StrafeRight()
		{
			NOI_straferight.NOI_LFS_StrafeRightController();
		}
		
		private void Load_NOI_LFS_StrafeLeft()
		{
			NOI_strafeleft.NOI_LFS_StrafeLeftController();
		}
	}
}