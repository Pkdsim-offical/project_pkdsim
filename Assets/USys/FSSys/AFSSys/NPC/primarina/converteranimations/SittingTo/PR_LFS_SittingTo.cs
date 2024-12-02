using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.SittingTo
{
	public class PR_LFS_SittingTo : MonoBehaviour 
	{
		private PR_LFS_SittingToStartWalking Primarina_LFS_sittingToStartWalking;
		private PR_LFS_SittingToStanding Primarina_LFS_sittingToStanding;
		public void PR_LFS_SittingToController()
		{
			PR_LFS_SittingToStartWalking();
			PR_LFS_SittingToStanding();
		}
		private void PR_LFS_SittingToStartWalking()
		{
			Primarina_LFS_sittingToStartWalking.PR_LFS_SittingToStartWalkingController();
		}
		private void PR_LFS_SittingToStanding()
		{
			Primarina_LFS_sittingToStanding.PR_LFS_SittingToStandingController();
		}

	}
}