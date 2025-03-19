using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo
{
	public class BR_LFS_WalkingTo : MonoBehaviour 
	{
		private BR_LFS_WalkingToStanding Braixen_LFS_WalkingToStanding;
		private BR_LFS_WalkingToSitting Braixen_LFS_WalkingToSitting;
		public void BR_LFS_WalkingToController()
		{
			Load_BR_LFS_WalkingToStanding();
			Load_BR_LFS_WalkingToWSitting();
		}
		private void Load_BR_LFS_WalkingToStanding()
		{
			Braixen_LFS_WalkingToStanding.BR_LFS_WalkingToStandingController();
		}
		private void Load_BR_LFS_WalkingToWSitting()
		{
			Braixen_LFS_WalkingToSitting.BR_LFS_WalkingToSittingController();
		}
	}
}