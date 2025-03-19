using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.SittingTo
{
	public class LO_LFS_SittingTo : MonoBehaviour 
	{
		private LO_LFS_SittingToStartWalking Lopunny_LFS_sittingToStartWalking;
		private LO_LFS_SittingToStanding Lopunny_LFS_sittingToStanding;
		public void LO_LFS_SittingToController()
		{
			LO_LFS_SittingToStartWalking();
			LO_LFS_SittingToStanding();
		}
		private void LO_LFS_SittingToStartWalking()
		{
			Lopunny_LFS_sittingToStartWalking.LO_LFS_SittingToStartWalkingController();
		}
		private void LO_LFS_SittingToStanding()
		{
			Lopunny_LFS_sittingToStanding.LO_LFS_SittingToStandingController();
		}

	}
}