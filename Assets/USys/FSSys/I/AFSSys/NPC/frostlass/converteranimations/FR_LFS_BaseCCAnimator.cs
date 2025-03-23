using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Frostlass.converteranimations
{
	public class Frostlass_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private FR_LFS_SittingTo Frostlass_LFS_sittingto;
		
		private FR_LFS_WalkingTo Frostlass_LFS_walkingto;
		
		private FR_LFS_IdleTo Frostlass_LFS_idleto;

		public void FR_LFS_CoverterToAnimatorController()
		{
			Frostlass_LFS_walkingto.FR_LFS_WalkingToController();

			Frostlass_LFS_idleto.FR_LFS_IdleToController();
			
			Frostlass_LFS_sittingto.FR_LFS_SittingToController();	
		}
	}
}