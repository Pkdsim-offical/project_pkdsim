using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.SittingTo
{
	public class BR_LFS_SittingTo : MonoBehaviour 
	{
		private BR_LFS_SittingToStartWalking Braixen_LFS_sittingToStartWalking;
		private BR_LFS_SittingToStanding Braixen_LFS_sittingToStanding;
		public void BR_LFS_SittingToController()
		{
			BR_LFS_SittingToStartWalking();
			BR_LFS_SittingToStanding();
		}
		private void BR_LFS_SittingToStartWalking()
		{
			Braixen_LFS_sittingToStartWalking.BR_LFS_SittingToStartWalkingController();
		}
		private void BR_LFS_SittingToStanding()
		{
			Braixen_LFS_sittingToStanding.BR_LFS_SittingToStandingController();
		}

	}
}