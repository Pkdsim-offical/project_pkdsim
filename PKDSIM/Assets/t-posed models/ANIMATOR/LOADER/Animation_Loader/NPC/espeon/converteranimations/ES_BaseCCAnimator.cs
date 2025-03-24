using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.converteranimations.SittingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.converteranimations.WalkingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Espeon.idlebaseanimation
{
	public class Espeon_AnimatorConverterController : MonoBehaviour 
	{
		private ES_IdleTo Espeon_idleto;
		
		private ES_WalkingTo Espeon_walkingto;

		private ES_SittingTo Espeon_sittingto;
		private void Espeon_BaseIdleAnimatorController()
		{
			Espeon_walkingto.ES_WalkingToController();

			Espeon_idleto.ES_IdleToController();
			
			Espeon_sittingto.ES_SittingToController();
		}
	}
}