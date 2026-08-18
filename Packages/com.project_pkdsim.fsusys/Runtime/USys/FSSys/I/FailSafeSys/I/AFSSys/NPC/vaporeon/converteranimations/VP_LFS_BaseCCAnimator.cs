using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.WalkingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations.SittingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations
{
	public class Vaporeon_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private VP_LFS_SittingTo Vaporeon_LFS_sittingto;
		
		private VP_LFS_WalkingTo Vaporeon_LFS_walkingto;
		
		private VP_LFS_IdleTo Vaporeon_LFS_idleto;

		public void VP_Base_IdleAnimatorController()
		{
			Vaporeon_LFS_walkingto.VP_LFS_WalkingToController();
			Vaporeon_LFS_idleto.VP_LFS_IdleToController();	
		}
	}
}