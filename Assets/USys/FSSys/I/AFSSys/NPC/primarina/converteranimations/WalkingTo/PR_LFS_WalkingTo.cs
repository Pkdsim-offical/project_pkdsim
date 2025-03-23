using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo
{
	public class PR_LFS_WalkingTo : MonoBehaviour 
	{
		private PR_LFS_WalkingToStanding Primarina_LFS_WalkingToStanding;
		private PR_LFS_WalkingToSitting Primarina_LFS_WalkingToSitting;
		public void PR_LFS_WalkingToController()
		{
			Load_PR_LFS_WalkingToStanding();
			Load_PR_LFS_WalkingToWSitting();
		}
		private void Load_PR_LFS_WalkingToStanding()
		{
			Primarina_LFS_WalkingToStanding.PR_LFS_WalkingToStandingController();
		}
		private void Load_PR_LFS_WalkingToWSitting()
		{
			Primarina_LFS_WalkingToSitting.PR_LFS_WalkingToSittingController();
		}
	}
}