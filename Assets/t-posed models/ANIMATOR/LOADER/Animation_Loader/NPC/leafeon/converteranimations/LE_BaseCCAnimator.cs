using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.converteranimations.WalkingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.converteranimations.IdleTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.converteranimations.SittingTo;
using UnityEngine;


namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Leafeon.converteranimations
{
	public class Leafeon_CoverterAnimatorController : MonoBehaviour 
	{
		private LE_SittingTo Leafeon_sittingto;
		
		private LE_WalkingTo Leafeon_walkingto;
		
		private LE_IdleTo Leafeon_idleto;

		private void LE_BaseIdleAnimatorController()
		{
			Leafeon_walkingto.LE_WalkingToController();

			Leafeon_idleto.LE_IdleToController();
			
			Leafeon_sittingto.LE_SittingToController();	
		}
	}
}