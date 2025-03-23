using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo
{
	public class FR_LFS_WalkingTo : MonoBehaviour 
	{
		
		private FR_LFS_WalkingToStanding Frostlass_LFS_WalkingToStanding;
		private FR_LFS_WalkingToSitting Frostlass_LFS_WalkingToSitting;
		public void FR_LFS_WalkingToController()
		{
			Load_FR_LFS_WalkingToStanding();
			Load_FR_LFS_WalkingToWSitting();
		}
		private void Load_FR_LFS_WalkingToStanding()
		{
			Frostlass_LFS_WalkingToStanding.FR_LFS_WalkingToStandingController();
		}
		private void Load_FR_LFS_WalkingToWSitting()
		{
			Frostlass_LFS_WalkingToSitting.FR_LFS_WalkingToSittingController();
		}
	}
}