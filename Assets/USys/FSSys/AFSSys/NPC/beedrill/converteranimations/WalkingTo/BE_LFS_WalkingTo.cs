using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo
{
	public class BE_LFS_WalkingTo : MonoBehaviour 
	{
		private BE_LFS_WalkingToStanding Beedrill_LFS_WalkingToStanding;
		private BE_LFS_WalkingToSitting Beedrill_LFS_WalkingToSitting;
		public void BE_LFS_WalkingToController()
		{
			Load_BE_LFS_WalkingToStanding();
			Load_BE_LFS_WalkingToWSitting();
		}
		private void Load_BE_LFS_WalkingToStanding()
		{
			Beedrill_LFS_WalkingToStanding.BE_LFS_WalkingToStandingController();
		}
		private void Load_BE_LFS_WalkingToWSitting()
		{
			Beedrill_LFS_WalkingToSitting.BE_LFS_WalkingToSittingController();
		}
	}
}