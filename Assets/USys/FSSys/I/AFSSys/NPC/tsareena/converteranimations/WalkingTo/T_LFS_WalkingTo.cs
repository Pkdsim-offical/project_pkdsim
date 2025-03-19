using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo.WalkingToStanding;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo.WalkingToSitting;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.WalkingTo
{
	public class T_LFS_WalkingTo : MonoBehaviour 
	{
		private T_LFS_WalkingToSitting Tsareena_LFS_WalkingToSitting;
		private T_LFS_WalkingToStanding Tsareena_LFS_WalkingToStanding;
		public void T_LFS_WalkingToController()
		{
			T_LFS_WalkingToSitting();
			T_LFS_WalkingToStanding();
		}
		private void T_LFS_WalkingToSitting()
		{
			Tsareena_LFS_WalkingToSitting.T_LFS_WalkingToSittingController();
		}
		private void T_LFS_WalkingToStanding()
		{
			Tsareena_LFS_WalkingToStanding.T_LFS_WalkingToStandingController();
		}
	}
}