using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo
{
	public class GARD_LFS_SittingTo : MonoBehaviour 
	{
		private GARD_LFS_SittingToStartWalking Gardevoir_LFS_sittingToStartWalking;
		private GARD_LFS_SittingToStanding Gardevoir_LFS_sittingToStanding;
		public void GARD_LFS_SittingToController()
		{
			GARD_LFS_SittingToStartWalking();
			GARD_LFS_SittingToStanding();
		}
		private void GARD_LFS_SittingToStartWalking()
		{
			Gardevoir_LFS_sittingToStartWalking.GARD_LFS_SittingToStartWalkingController();
		}
		private void GARD_LFS_SittingToStanding()
		{
			Gardevoir_LFS_sittingToStanding.GARD_LFS_SittingToStandingController();
		}
	}
}