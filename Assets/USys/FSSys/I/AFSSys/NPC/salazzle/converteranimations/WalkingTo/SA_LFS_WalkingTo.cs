using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo
{
	public class SA_LFS_WalkingTo : MonoBehaviour 
	{
		private SA_LFS_WalkingToSitting Salazzle_LFS_WalkingToSitting;
		private SA_LFS_WalkingToStanding Salazzle_LFS_WalkingToStanding;
		public void SA_LFS_WalkingToController()
		{
			SA_LFS_WalkingToSitting();
			SA_LFS_WalkingToStanding();
		}
		private void SA_LFS_WalkingToSitting()
		{
			Salazzle_LFS_WalkingToSitting.SA_LFS_WalkingToSittingController();
		}
		private void SA_LFS_WalkingToStanding()
		{
			Salazzle_LFS_WalkingToStanding.SA_LFS_WalkingToStandingController();
		}
	}
}