using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.WalkingTo
{
	public class SYL_LFS_WalkingTo : MonoBehaviour 
	{
		private SYL_LFS_WalkingToSitting Sylveon_LFS_WalkingToSitting;
		private SYL_LFS_WalkingToStanding Sylveon_LFS_WalkingToStanding;
		public void SYL_LFS_WalkingToController()
		{
			SYL_LFS_WalkingToSitting();
			SYL_LFS_WalkingToStanding();
		}
		private void SYL_LFS_WalkingToSitting()
		{
			Sylveon_LFS_WalkingToSitting.SYL_LFS_WalkingToSittingController();
		}
		private void SYL_LFS_WalkingToStanding()
		{
			Sylveon_LFS_WalkingToStanding.SYL_LFS_WalkingToStandingController();
		}
	}
}