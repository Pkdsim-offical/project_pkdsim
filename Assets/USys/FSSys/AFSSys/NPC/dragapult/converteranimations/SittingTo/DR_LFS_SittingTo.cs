using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo
{
	public class DR_LFS_SittingTo : MonoBehaviour 
	{
		private DR_LFS_SittingToStartWalking Dragapult_LFS_sittingToStartWalking;
		private DR_LFS_SittingToStanding Dragapult_LFS_sittingToStanding;
		public void DR_LFS_SittingToController()
		{
			DR_LFS_SittingToStartWalking();
			DR_LFS_SittingToStanding();
		}
		private void DR_LFS_SittingToStartWalking()
		{
			Dragapult_LFS_sittingToStartWalking.DR_LFS_SittingToStartWalkingController();
		}
		private void DR_LFS_SittingToStanding()
		{
			Dragapult_LFS_sittingToStanding.DR_LFS_SittingToStandingController();
		}
	}
}