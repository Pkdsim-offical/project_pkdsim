using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo
{
	public class GARC_LFS_WalkingTo : MonoBehaviour 
	{
		private GARC_LFS_WalkingToStanding Garchomp_LFS_WalkingToStanding;
		private GARC_LFS_WalkingToSitting Garchomp_LFS_WalkingToSitting;
		public void GARC_LFS_WalkingToController()
		{
			Load_GARC_LFS_WalkingToStanding();
			Load_GARC_LFS_WalkingToWSitting();
		}
		private void Load_GARC_LFS_WalkingToStanding()
		{
			Garchomp_LFS_WalkingToStanding.GARC_LFS_WalkingToStandingController();
		}
		private void Load_GARC_LFS_WalkingToWSitting()
		{
			Garchomp_LFS_WalkingToSitting.GARC_LFS_WalkingToSittingController();
		}
	}
}