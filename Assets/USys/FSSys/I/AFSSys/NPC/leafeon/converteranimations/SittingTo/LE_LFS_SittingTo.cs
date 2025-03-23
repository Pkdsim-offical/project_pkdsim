using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo.SittingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo.SittingToStartWalking;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.SittingTo
{
	public class LE_LFS_SittingTo : MonoBehaviour 
	{
		private LE_LFS_SittingToStartWalking Leafeon_LFS_sittingToStartWalking;
		private LE_LFS_SittingToStanding Leafeon_LFS_sittingToStanding;
		public void LE_LFS_SittingToController()
		{
			LE_LFS_SittingToStartWalking();
			LE_LFS_SittingToStanding();
		}
		private void LE_LFS_SittingToStartWalking()
		{
			Leafeon_LFS_sittingToStartWalking.LE_LFS_SittingToStartWalkingController();
		}
		private void LE_LFS_SittingToStanding()
		{
			Leafeon_LFS_sittingToStanding.LE_LFS_SittingToStandingController();
		}
	}
}