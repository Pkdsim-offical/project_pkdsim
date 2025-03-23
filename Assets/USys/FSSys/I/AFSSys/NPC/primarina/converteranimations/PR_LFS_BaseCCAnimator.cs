using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Primarina.converteranimations
{
	public class Primarina_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private PR_LFS_SittingTo Primarina_LFS_sittingto;
		
		private PR_LFS_WalkingTo Primarina_LFS_walkingto;
		
		private PR_LFS_IdleTo Primarina_LFS_idleto;

		public void PR_LFS_CoverterToAnimatorController()
		{
			Primarina_LFS_walkingto.PR_LFS_WalkingToController();

			Primarina_LFS_idleto.PR_LFS_IdleToController();
			
			Primarina_LFS_sittingto.PR_LFS_SittingToController();	
		}
	}
}