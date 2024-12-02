using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Meowscarada.converteranimations.WalkingTo
{
	public class MEOW_LFS_WalkingTo : MonoBehaviour 
	{
		private MEOW_LFS_WalkingToSitting Meowscarada_LFS_WalkingToSitting;
		private MEOW_LFS_WalkingToStanding Meowscarada_LFS_WalkingToStanding;
		public void MEOW_LFS_WalkingToController()
		{
			MEOW_LFS_WalkingToSitting();
			MEOW_LFS_WalkingToStanding();
		}
		private void MEOW_LFS_WalkingToSitting()
		{
			Meowscarada_LFS_WalkingToSitting.MEOW_LFS_WalkingToSittingController();
		}
		private void MEOW_LFS_WalkingToStanding()
		{
			Meowscarada_LFS_WalkingToStanding.MEOW_LFS_WalkingToStandingController();
		}
	}
}