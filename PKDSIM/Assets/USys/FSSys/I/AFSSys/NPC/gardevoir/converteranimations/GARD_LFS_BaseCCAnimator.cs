using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Gardevoir.converteranimations
{
	public class Gardevoir_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private GARD_LFS_SittingTo Gardevoir_LFS_sittingto;
		
		private GARD_LFS_WalkingTo Gardevoir_LFS_walkingto;
		
		private GARD_LFS_IdleTo Gardevoir_LFS_idleto;

		public void GARD_LFS_CoverterToAnimatorController()
		{
			Gardevoir_LFS_walkingto.GARD_LFS_WalkingToController();

			Gardevoir_LFS_idleto.GARD_LFS_IdleToController();
			
			Gardevoir_LFS_sittingto.GARD_LFS_SittingToController();	
		}
	}
}