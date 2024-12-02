using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Salazzle.converteranimations
{
	public class Salazzle_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private SA_LFS_SittingTo Salazzle_LFS_sittingto;
		
		private SA_LFS_WalkingTo Salazzle_LFS_walkingto;
		
		private SA_LFS_IdleTo Salazzle_LFS_idleto;

		public void SA_LFS_CoverterToAnimatorController()
		{
			Salazzle_LFS_walkingto.SA_LFS_WalkingToController();

			Salazzle_LFS_idleto.SA_LFS_IdleToController();
			
			Salazzle_LFS_sittingto.SA_LFS_SittingToController();	
		}
	}
}