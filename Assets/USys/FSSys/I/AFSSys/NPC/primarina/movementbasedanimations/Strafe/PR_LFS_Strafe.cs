using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafe.StrafeLeft;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafe.StrafeRight;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.movementbasedanimations.Strafe
{
	public class PR_LFS_Strafing : MonoBehaviour 
	{
		private PR_LFS_StrafeLeft PR_strafeleft;
		
		private PR_LFS_StrafeRight PR_straferight;

		public void PR_LFS_StrafingController()
		{
			if (PR_strafeleft == null)
			{
				PR_strafeleft = GetComponent<PR_LFS_StrafeLeft>();
				Load_PR_LFS_StrafeLeft();
			}
			if (PR_straferight == null)
			{
				PR_straferight = GetComponent<PR_LFS_StrafeRight>();
				Load_PR_LFS_StrafeRight();
			}
			

		}
		private void Load_PR_LFS_StrafeRight()
		{
			PR_straferight.PR_LFS_StrafeRightController();
		}
		
		private void Load_PR_LFS_StrafeLeft()
		{
			PR_strafeleft.PR_LFS_StrafeLeftController();
		}
	}
}