using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafing
{
	public class JT_LFS_Strafing : MonoBehaviour 
	{
		private JT_LFS_StrafeLeft JT_strafeleft;
		
		private JT_LFS_StrafeRight JT_straferight;

		public void JT_LFS_StrafingController()
		{
			if (JT_strafeleft == null)
			{
				JT_strafeleft = GetComponent<JT_LFS_StrafeLeft>();
				Load_JT_LFS_StrafeLeft();
			}
			if (JT_straferight == null)
			{
				JT_straferight = GetComponent<JT_LFS_StrafeRight>();
				Load_JT_LFS_StrafeRight();
			}
			

		}
		private void Load_JT_LFS_StrafeRight()
		{
			JT_straferight.JT_LFS_StrafeRightController();
		}
		
		private void Load_JT_LFS_StrafeLeft()
		{
			JT_strafeleft.JT_LFS_StrafeLeftController();
		}
	}
}