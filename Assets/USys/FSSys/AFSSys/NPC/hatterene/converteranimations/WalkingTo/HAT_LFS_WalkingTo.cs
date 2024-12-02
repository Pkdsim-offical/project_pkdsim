using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.WalkingTo
{
	public class HAT_LFS_WalkingTo : MonoBehaviour 
	{
		private HAT_LFS_WalkingToStanding Hatterene_LFS_WalkingToStanding;
		private HAT_LFS_WalkingToSitting Hatterene_LFS_WalkingToSitting;
		public void HAT_LFS_WalkingToController()
		{
			Load_HAT_LFS_WalkingToStanding();
			Load_HAT_LFS_WalkingToWSitting();
		}
		private void Load_HAT_LFS_WalkingToStanding()
		{
			Hatterene_LFS_WalkingToStanding.HAT_LFS_WalkingToStandingController();
		}
		private void Load_HAT_LFS_WalkingToWSitting()
		{
			Hatterene_LFS_WalkingToSitting.HAT_LFS_WalkingToSittingController();
		}
	}
}