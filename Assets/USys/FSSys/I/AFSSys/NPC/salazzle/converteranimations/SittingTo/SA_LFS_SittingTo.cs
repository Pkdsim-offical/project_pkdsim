using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo
{
	public class SA_LFS_SittingTo : MonoBehaviour 
	{
		private SA_LFS_SittingToStartWalking Salazzle_LFS_sittingToStartWalking;
		private SA_LFS_SittingToStanding Salazzle_LFS_sittingToStanding;
		public void SA_LFS_SittingToController()
		{
			SA_LFS_SittingToStartWalking();
			SA_LFS_SittingToStanding();
		}
		private void SA_LFS_SittingToStartWalking()
		{
			Salazzle_LFS_sittingToStartWalking.SA_LFS_SittingToStartWalkingController();
		}
		private void SA_LFS_SittingToStanding()
		{
			Salazzle_LFS_sittingToStanding.SA_LFS_SittingToStandingController();
		}
	}
}