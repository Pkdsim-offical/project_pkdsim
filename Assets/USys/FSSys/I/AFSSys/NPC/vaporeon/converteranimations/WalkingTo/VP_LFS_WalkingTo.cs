using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.WalkingTo
{
	public class VP_LFS_WalkingTo : MonoBehaviour 
	{
		private VP_LFS_WalkingToStanding Vaporeon_LFS_WalkingToStanding;
		private VP_LFS_WalkingToSitting Vaporeon_LFS_WalkingToSitting;
		public void VP_LFS_WalkingToController()
		{
			Load_VP_LFS_WalkingToStanding();
			Load_VP_LFS_WalkingToWSitting();
		}
		private void Load_VP_LFS_WalkingToStanding()
		{
			Vaporeon_LFS_WalkingToStanding.VP_LFS_WalkingToStandingController();
		}
		private void Load_VP_LFS_WalkingToWSitting()
		{
			Vaporeon_LFS_WalkingToSitting.VP_LFS_WalkingToSittingController();
		}
	}
}