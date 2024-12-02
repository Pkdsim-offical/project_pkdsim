using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.movementbasedanimations.Strafe
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