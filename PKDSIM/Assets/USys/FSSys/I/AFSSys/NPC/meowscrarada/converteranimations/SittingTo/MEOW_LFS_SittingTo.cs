using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo.SittingToStartWalking;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo.SittingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.SittingTo
{
	public class MEOW_LFS_SittingTo : MonoBehaviour 
	{
		private MEOW_LFS_SittingToStartWalking Meowscarada_LFS_sittingToStartWalking;
		private MEOW_LFS_SittingToStanding Meowscarada_LFS_sittingToStanding;
		public void MEOW_LFS_SittingToController()
		{
			MEOW_LFS_SittingToStartWalking();
			MEOW_LFS_SittingToStanding();
		}
		private void MEOW_LFS_SittingToStartWalking()
		{
			Meowscarada_LFS_sittingToStartWalking.MEOW_LFS_SittingToStartWalkingController();
		}
		private void MEOW_LFS_SittingToStanding()
		{
			Meowscarada_LFS_sittingToStanding.MEOW_LFS_SittingToStandingController();
		}

	}
}