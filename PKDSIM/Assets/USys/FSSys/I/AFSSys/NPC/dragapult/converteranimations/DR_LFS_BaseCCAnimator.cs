using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Dragapult.converteranimations
{
	public class Dragapult_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private DR_LFS_SittingTo Dragapult_LFS_sittingto;
		
		private DR_LFS_WalkingTo Dragapult_LFS_walkingto;
		
		private DR_LFS_IdleTo Dragapult_LFS_idleto;

		public void DR_LFS_CoverterToAnimatorController()
		{
			Dragapult_LFS_walkingto.DR_LFS_WalkingToController();

			Dragapult_LFS_idleto.DR_LFS_IdleToController();
			
			Dragapult_LFS_sittingto.DR_LFS_SittingToController();	
		}
	}
}