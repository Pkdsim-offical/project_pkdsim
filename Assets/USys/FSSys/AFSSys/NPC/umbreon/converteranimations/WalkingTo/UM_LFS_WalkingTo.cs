using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Umbreon.converteranimations.WalkingTo
{
	public class UM_LFS_WalkingTo : MonoBehaviour 
	{
		private UM_LFS_WalkingToStanding Umbreon_LFS_WalkingToStanding;
		private UM_LFS_WalkingToSitting Umbreon_LFS_WalkingToSitting;
		public void UM_LFS_WalkingToController()
		{
			Load_UM_LFS_WalkingToStanding();
			Load_UM_LFS_WalkingToWSitting();
		}
		private void Load_UM_LFS_WalkingToStanding()
		{
			Umbreon_LFS_WalkingToStanding.UM_LFS_WalkingToStandingController();
		}
		private void Load_UM_LFS_WalkingToWSitting()
		{
			Umbreon_LFS_WalkingToSitting.UM_LFS_WalkingToSittingController();
		}
	}
}