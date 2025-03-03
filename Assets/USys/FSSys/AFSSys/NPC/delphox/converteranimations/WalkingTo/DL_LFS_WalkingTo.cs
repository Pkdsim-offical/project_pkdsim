using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Delphox.converteranimations.WalkingTo
{
	public class DL_LFS_WalkingTo : MonoBehaviour 
	{
		private DL_LFS_WalkingToSitting Delphox_LFS_WalkingToSitting;
		private DL_LFS_WalkingToStanding Delphox_LFS_WalkingToStanding;
		public void DL_LFS_WalkingToController() 
		{
			Load_DL_LFS_WalkingToSitting();
			Load_DL_LFS_WalkingToStanding();
		}
		private void Load_DL_LFS_WalkingToStanding()
		{
			Delphox_LFS_WalkingToStanding.DL_LFS_WalkingToStandingController();
		}
		private void Load_DL_LFS_WalkingToSitting()
		{
			Delphox_LFS_WalkingToSitting.DL_LFS_WalkingToSittingController();
		}
	}
}