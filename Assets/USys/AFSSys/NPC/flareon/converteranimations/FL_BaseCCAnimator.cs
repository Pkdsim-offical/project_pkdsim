using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.AFSSys.ANIMATOR.NPC.Flareon.converteranimations
{
	public class Flareon_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private FL_LFS_SittingTo Jolteon_LFS_sittingto;
		
		private FL_LFS_WalkingTo Jolteon_LFS_walkingto;
		
		private FL_LFS_IdleTo Jolteon_LFS_idleto;

		public void FL_LFS_CoverterToAnimatorController()
		{
			Jolteon_LFS_walkingto.FL_LFS_WalkingToController();

			Jolteon_LFS_idleto.FL_LFS_IdleToController();
			
			Jolteon_LFS_sittingto.FL_LFS_SittingToController();	
		}
	}
}