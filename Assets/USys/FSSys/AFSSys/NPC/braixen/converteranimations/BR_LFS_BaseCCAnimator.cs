using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Braixen.converteranimations
{
	public class Braixen_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private BR_LFS_SittingTo Braixen_LFS_sittingto;
		
		private BR_LFS_WalkingTo Braixen_LFS_walkingto;
		
		private BR_LFS_IdleTo Braixen_LFS_idleto;

		public void BR_LFS_CoverterToAnimatorController()
		{
			Braixen_LFS_walkingto.BR_LFS_WalkingToController();

			Braixen_LFS_idleto.BR_LFS_IdleToController();
			
			Braixen_LFS_sittingto.BR_LFS_SittingToController();	
		}
	}
}