using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Absol.converteranimations.SittingTo
{
	public class AB_LFS_SittingTo : MonoBehaviour 
	{
		private AB_LFS_SittingToStartWalking Absol_LFS_sittingToStartWalking;
		private AB_LFS_SittingToStanding Absol_LFS_sittingToStanding;
		public void AB_LFS_SittingToController()
		{
			AB_LFS_SittingToStartWalking();
			AB_LFS_SittingToStanding();
		}
		private void AB_LFS_SittingToStartWalking()
		{
			Absol_LFS_sittingToStartWalking.AB_LFS_SittingToStartWalkingController();
		}
		private void AB_LFS_SittingToStanding()
		{
			Absol_LFS_sittingToStanding.AB_LFS_SittingToStandingController();
		}

	}
}