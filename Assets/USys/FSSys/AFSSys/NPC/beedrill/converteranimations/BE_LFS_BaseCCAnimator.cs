using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Beedrill.converteranimations
{
	public class Beedrill_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private BE_LFS_SittingTo Beedrill_LFS_sittingto;
		
		private BE_LFS_WalkingTo Beedrill_LFS_walkingto;
		
		private BE_LFS_IdleTo Beedrill_LFS_idleto;

		public void BE_LFS_CoverterToAnimatorController()
		{
			Beedrill_LFS_walkingto.BE_LFS_WalkingToController();

			Beedrill_LFS_idleto.BE_LFS_IdleToController();
			
			Beedrill_LFS_sittingto.BE_LFS_SittingToController();	
		}
	}
}