using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Jolteon.converteranimations
{
	public class Jolteon_LFS_AnimatorControllerCoverterAnimator : MonoBehaviour 
	{
		private JT_LFS_SittingTo Jolteon_LFS_sittingto;
		
		private JT_LFS_WalkingTo Jolteon_LFS_walkingto;
		
		private JT_LFS_IdleTo Jolteon_LFS_idleto;

		private void VAPOR_BaseIdleAnimatorController()
		{
			Jolteon_LFS_walkingto.JT_LFS_WalkingToController();

			Jolteon_LFS_idleto.JT_LFS_IdleToController();
			
			Jolteon_LFS_sittingto.JT_LFS_SittingToController();	
		}
	}
}