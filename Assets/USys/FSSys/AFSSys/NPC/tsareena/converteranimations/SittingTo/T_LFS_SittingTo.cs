using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.converteranimations.SittingTo
{
	public class T_LFS_SittingTo : MonoBehaviour 
	{
		private T_LFS_SittingToStartWalking Tsareena_LFS_sittingToStartWalking;
		private T_LFS_SittingToStanding Tsareena_LFS_sittingToStanding;
		public void T_LFS_SittingToController()
		{
			T_LFS_SittingToStartWalking();
			T_LFS_SittingToStanding();
		}
		private void T_LFS_SittingToStartWalking()
		{
			Tsareena_LFS_sittingToStartWalking.T_LFS_SittingToStartWalkingController();
		}
		private void T_LFS_SittingToStanding()
		{
			Tsareena_LFS_sittingToStanding.T_LFS_SittingToStandingController();
		}

	}
}