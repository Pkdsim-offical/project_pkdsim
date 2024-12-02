using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.converteranimations.SittingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.converteranimations.WalkingTo;
using project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.converteranimations.IdleTo;
using UnityEngine;

namespace project_pkdsim.Assets.Models.ANIMATOR.Loader.Animation_Loader.NPC.Glaceon.converteranimations
{
	public class Glaceon_AnimatorControllerCoverterAnimator : MonoBehaviour 
	{
		private GL_IdleTo Glaceon_idleto;
		
		private GL_WalkingTo Glaceon_walkingto;

		private GL_SittingTo Glaceon_sittingto;
		private void Glaceon_BaseIdleAnimatorController()
		{
			Glaceon_walkingto.GL_WalkingToController();

			Glaceon_idleto.GL_IdleToController();
			
			Glaceon_sittingto.GL_SittingToController();	
		}
	}
}