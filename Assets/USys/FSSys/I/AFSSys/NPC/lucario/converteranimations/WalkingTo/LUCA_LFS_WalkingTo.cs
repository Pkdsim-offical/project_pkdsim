using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lucario.converteranimations.WalkingTo
{
	public class LUCA_LFS_WalkingTo : MonoBehaviour 
	{
		private LUCA_LFS_WalkingToStanding Lucario_LFS_WalkingToStanding;
		private LUCA_LFS_WalkingToSitting Lucario_LFS_WalkingToSitting;
		public void LUCA_LFS_WalkingToController()
		{
			Load_LUCA_LFS_WalkingToStanding();
			Load_LUCA_LFS_WalkingToWSitting();
		}
		private void Load_LUCA_LFS_WalkingToStanding()
		{
			Lucario_LFS_WalkingToStanding.LUCA_LFS_WalkingToStandingController();
		}
		private void Load_LUCA_LFS_WalkingToWSitting()
		{
			Lucario_LFS_WalkingToSitting.LUCA_LFS_WalkingToSittingController();
		}
	}
}