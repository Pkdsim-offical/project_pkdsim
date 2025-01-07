using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.converteranimations.WalkingTo.WalkingToSitting;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.converteranimations.WalkingTo.WalkingToStanding;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Vaporeon.converteranimations.WalkingTo
{
	public class VP_WalkingTo : MonoBehaviour 
	{
		private VP_WalkingToSitting VP_WalkingToSitting;
		
		private VP_WalkingToStanding VP_WalkingToStanding;

		public void VP_WalkingToController() 
		{
			VP_WalkingToSittingController();
			VP_WalkingToStandingController();
		}
		private void VP_WalkingToSittingController()
		{
			VP_WalkingToSitting.VP_WalkingToSittingController();
		}
		private void VP_WalkingToStandingController()
		{
			VP_WalkingToStanding.VP_WalkingToStandingController();
		}
	}
}