using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Hatterene.converteranimations.SittingTo
{
	public class HAT_LFS_SittingTo : MonoBehaviour 
	{
		private HAT_LFS_SittingToStartWalking Hatterene_LFS_sittingToStartWalking;
		private HAT_LFS_SittingToStanding Hatterene_LFS_sittingToStanding;
		public void HAT_LFS_SittingToController()
		{
			HAT_LFS_SittingToStartWalking();
			HAT_LFS_SittingToStanding();
		}
		private void HAT_LFS_SittingToStartWalking()
		{
			Hatterene_LFS_sittingToStartWalking.HAT_LFS_SittingToStartWalkingController();
		}
		private void HAT_LFS_SittingToStanding()
		{
			Hatterene_LFS_sittingToStanding.HAT_LFS_SittingToStandingController();
		}
	}
}