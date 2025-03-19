using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo
{
	public class ES_LFS_WalkingTo : MonoBehaviour 
	{
		private ES_LFS_WalkingToSitting Espeon_LFS_WalkingToSitting;
		private ES_LFS_WalkingToStanding Espeon_LFS_WalkingToStanding;
		public void ES_LFS_WalkingToController()
		{
			Load_ES_LFS_WalkingToStartWalking();
			Load_ES_LFS_WalkingToStanding();
		}
		private void Load_ES_LFS_WalkingToStartWalking()
		{
			Espeon_LFS_WalkingToSitting.ES_LFS_WalkingToSittingController();
		}
		private void Load_ES_LFS_WalkingToStanding()
		{
			Espeon_LFS_WalkingToStanding.ES_LFS_WalkingToStandingController();
		}
	}
}