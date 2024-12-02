using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Cinderace.converteranimations
{
	public class Cinderace_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private C_LFS_SittingTo Cinderace_LFS_sittingto;
		
		private C_LFS_WalkingTo Cinderace_LFS_walkingto;
		
		private C_LFS_IdleTo Cinderace_LFS_idleto;

		public void C_LFS_CoverterToAnimatorController()
		{
			Cinderace_LFS_walkingto.C_LFS_WalkingToController();

			Cinderace_LFS_idleto.C_LFS_IdleToController();
			
			Cinderace_LFS_sittingto.C_LFS_SittingToController();	
		}
	}
}