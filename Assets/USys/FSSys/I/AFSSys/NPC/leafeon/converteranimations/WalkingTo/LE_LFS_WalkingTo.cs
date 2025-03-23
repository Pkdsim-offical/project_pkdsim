using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations.WalkingTo
{
	public class LE_LFS_WalkingTo : MonoBehaviour 
	{
		private LE_LFS_WalkingToStanding Leafeon_LFS_WalkingToStanding;
		private LE_LFS_WalkingToSitting Leafeon_LFS_WalkingToSitting;
		public void LE_LFS_WalkingToController()
		{
			Load_LE_LFS_WalkingToStanding();
			Load_LE_LFS_WalkingToWSitting();
		}
		private void Load_LE_LFS_WalkingToStanding()
		{
			Leafeon_LFS_WalkingToStanding.LE_LFS_WalkingToStandingController();
		}
		private void Load_LE_LFS_WalkingToWSitting()
		{
			Leafeon_LFS_WalkingToSitting.LE_LFS_WalkingToSittingController();
		}
	}
}