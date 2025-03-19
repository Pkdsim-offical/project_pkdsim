using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Garchomp.converteranimations
{
	public class Garchomp_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private GARC_LFS_SittingTo Garchomp_LFS_sittingto;
		
		private GARC_LFS_WalkingTo Garchomp_LFS_walkingto;
		
		private GARC_LFS_IdleTo Garchomp_LFS_idleto;

		public void GARC_LFS_CoverterToAnimatorController()
		{
			Garchomp_LFS_walkingto.GARC_LFS_WalkingToController();

			Garchomp_LFS_idleto.GARC_LFS_IdleToController();
			
			Garchomp_LFS_sittingto.GARC_LFS_SittingToController();	
		}
	}
}