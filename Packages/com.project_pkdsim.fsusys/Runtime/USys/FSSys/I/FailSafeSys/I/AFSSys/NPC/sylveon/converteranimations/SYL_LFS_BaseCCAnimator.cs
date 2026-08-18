using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Sylveon.converteranimations
{
	public class Sylveon_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private SYL_LFS_SittingTo Sylveon_LFS_sittingto;
		
		private SYL_LFS_WalkingTo Sylveon_LFS_walkingto;
		
		private SYL_LFS_IdleTo Sylveon_LFS_idleto;

		public void SYL_LFS_ConverterAnimatorController()
		{
			Sylveon_LFS_walkingto.SYL_LFS_WalkingToController();

			Sylveon_LFS_idleto.SYL_LFS_IdleToController();
			
			Sylveon_LFS_sittingto.SYL_LFS_SittingToController();	
		}
	}
}