using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Espeon.converteranimations
{
	public class Espeon_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private ES_LFS_SittingTo Espeon_LFS_sittingto;
		
		private ES_LFS_WalkingTo Espeon_LFS_walkingto;
		
		private ES_LFS_IdleTo Espeon_LFS_idleto;

		public void ES_LFS_CoverterToAnimatorController()
		{
			Espeon_LFS_walkingto.ES_LFS_WalkingToController();

			Espeon_LFS_idleto.ES_LFS_IdleToController();
			
			Espeon_LFS_sittingto.ES_LFS_SittingToController();	
		}
	}
}