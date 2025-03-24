using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.SittingTo
{
	public class VP_LFS_SittingTo : MonoBehaviour 
	{
		private VP_LFS_SittingToStartWalking Vaporeon_LFS_sittingToStartWalking;
		private VP_LFS_SittingToStanding Vaporeon_LFS_sittingToStanding;
		public void VP_LFS_SittingToController()
		{
			VP_LFS_SittingToStartWalking();
			VP_LFS_SittingToStanding();
		}
		private void VP_LFS_SittingToStartWalking()
		{
			Vaporeon_LFS_sittingToStartWalking.VP_LFS_SittingToStartWalkingController();
		}
		private void VP_LFS_SittingToStanding()
		{
			Vaporeon_LFS_sittingToStanding.VP_LFS_SittingToStandingController();
		}
	}
}