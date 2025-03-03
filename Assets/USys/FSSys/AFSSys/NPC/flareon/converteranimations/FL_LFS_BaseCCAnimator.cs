using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Flareon.converteranimations
{
	public class Flareon_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private FL_LFS_SittingTo Flareon_LFS_sittingto;
		
		private FL_LFS_WalkingTo Flareon_LFS_walkingto;
		
		private FL_LFS_IdleTo Flareon_LFS_idleto;

		public void FL_LFS_CoverterToAnimatorController()
		{
			Flareon_LFS_walkingto.FL_LFS_WalkingToController();

			Flareon_LFS_idleto.FL_LFS_IdleToController();
			
			Flareon_LFS_sittingto.FL_LFS_SittingToController();	
		}
	}
}