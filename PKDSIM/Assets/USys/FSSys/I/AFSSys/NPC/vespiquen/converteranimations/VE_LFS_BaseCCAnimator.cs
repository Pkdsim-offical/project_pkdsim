using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Vespiquen.converteranimations
{
	public class Vespiquen_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private VE_LFS_SittingTo Vespiquen_LFS_sittingto;
		
		private VE_LFS_WalkingTo Vespiquen_LFS_walkingto;
		
		private VE_LFS_IdleTo Vespiquen_LFS_idleto;

		public void VE_LFS_CoverterToAnimatorController()
		{
			Vespiquen_LFS_walkingto.VE_LFS_WalkingToController();

			Vespiquen_LFS_idleto.VE_LFS_IdleToController();
			
			Vespiquen_LFS_sittingto.VE_LFS_SittingToController();	
		}
	}
}