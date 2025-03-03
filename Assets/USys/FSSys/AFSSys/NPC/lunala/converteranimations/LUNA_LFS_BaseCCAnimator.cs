using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lunala.converteranimations
{
	public class Lunala_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private LUNA_LFS_SittingTo Lunala_LFS_sittingto;
		
		private LUNA_LFS_WalkingTo Lunala_LFS_walkingto;
		
		private LUNA_LFS_IdleTo Lunala_LFS_idleto;

		public void LUNA_LFS_CoverterToAnimatorController()
		{
			Lunala_LFS_walkingto.LUNA_LFS_WalkingToController();

			Lunala_LFS_idleto.LUNA_LFS_IdleToController();
			
			Lunala_LFS_sittingto.LUNA_LFS_SittingToController();	
		}
	}
}