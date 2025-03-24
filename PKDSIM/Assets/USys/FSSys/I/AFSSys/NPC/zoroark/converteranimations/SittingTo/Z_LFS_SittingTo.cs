using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Zoroark.converteranimations.SittingTo
{
	public class Z_LFS_SittingTo : MonoBehaviour 
	{
		private Z_LFS_SittingToStartWalking Zoroark_LFS_sittingToStartWalking;
		private Z_LFS_SittingToStanding Zoroark_LFS_sittingToStanding;
		public void Z_LFS_SittingToController()
		{
			Z_LFS_SittingToStartWalking();
			Z_LFS_SittingToStanding();
		}
		private void Z_LFS_SittingToStartWalking()
		{
			Zoroark_LFS_sittingToStartWalking.Z_LFS_SittingToStartWalkingController();
		}
		private void Z_LFS_SittingToStanding()
		{
			Zoroark_LFS_sittingToStanding.Z_LFS_SittingToStandingController();
		}

	}
}