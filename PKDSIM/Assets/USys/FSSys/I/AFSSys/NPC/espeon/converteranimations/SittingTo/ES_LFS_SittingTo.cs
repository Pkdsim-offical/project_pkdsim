using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.SittingTo
{
	public class ES_LFS_SittingTo : MonoBehaviour 
	{
		private ES_LFS_SittingToStartWalking Espeon_LFS_sittingToStartWalking;
		private ES_LFS_SittingToStanding Espeon_LFS_sittingToStanding;
		public void ES_LFS_SittingToController()
		{
			Load_ES_LFS_SittingToStartWalking();
			Load_ES_LFS_SittingToStanding();
		}
		private void Load_ES_LFS_SittingToStartWalking()
		{
			Espeon_LFS_sittingToStartWalking.ES_LFS_SittingToStartWalkingController();
		}
		private void Load_ES_LFS_SittingToStanding()
		{
			Espeon_LFS_sittingToStanding.ES_LFS_SittingToStandingController();
		}
	}
}