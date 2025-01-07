using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.converteranimations.SittingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.converteranimations.WalkingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Umbreon.converteranimations
{
	public class Umbreon_AnimatorBaseConverterController : MonoBehaviour 
	{
		private UM_SittingTo Umbreon_sittingto;
		
		private UM_WalkingTo Umbreon_walkingto;
		
		private UM_IdleTo Umbreon_idleto;

		private void UM_BaseIdleAnimatorController()
		{
			Umbreon_walkingto.UM_WalkingToController();

			Umbreon_idleto.UM_IdleToController();
			
			Umbreon_sittingto.UM_SittingToController();	
		}
	}
}