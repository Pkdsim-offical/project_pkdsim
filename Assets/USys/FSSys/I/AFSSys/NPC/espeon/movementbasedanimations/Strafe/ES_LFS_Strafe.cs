using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.movementbasedanimations.Strafe
{
	public class ES_LFS_Strafing : MonoBehaviour 
	{
		private ES_LFS_StrafeLeft ES_strafeleft;
		
		private ES_LFS_StrafeRight ES_straferight;

		public void ES_LFS_StrafingController()
		{
			if (ES_strafeleft == null)
			{
				ES_strafeleft = GetComponent<ES_LFS_StrafeLeft>();
				Load_ES_LFS_StrafeLeft();
			}
			if (ES_straferight == null)
			{
				ES_straferight = GetComponent<ES_LFS_StrafeRight>();
				Load_ES_LFS_StrafeRight();
			}
			

		}
		private void Load_ES_LFS_StrafeRight()
		{
			ES_straferight.ES_LFS_StrafeRightController();
		}
		
		private void Load_ES_LFS_StrafeLeft()
		{
			ES_strafeleft.ES_LFS_StrafeLeftController();
		}
	}
}