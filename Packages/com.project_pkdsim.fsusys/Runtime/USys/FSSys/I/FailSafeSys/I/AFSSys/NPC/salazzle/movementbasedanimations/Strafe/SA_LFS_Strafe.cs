using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.movementbasedanimations.Strafing
{
	public class SA_LFS_Strafing : MonoBehaviour 
	{
		private SA_LFS_StrafeLeft SA_strafeleft;
		
		private SA_LFS_StrafeRight SA_straferight;

		public void SA_LFS_StrafingController()
		{
			if (SA_strafeleft == null)
			{
				SA_strafeleft = GetComponent<SA_LFS_StrafeLeft>();
				Load_SA_LFS_StrafeLeft();
			}
			if (SA_straferight == null)
			{
				SA_straferight = GetComponent<SA_LFS_StrafeRight>();
				Load_SA_LFS_StrafeRight();
			}
			

		}
		private void Load_SA_LFS_StrafeRight()
		{
			SA_straferight.SA_LFS_StrafeRightController();
		}
		
		private void Load_SA_LFS_StrafeLeft()
		{
			SA_strafeleft.SA_LFS_StrafeLeftController();
		}
	}
}