using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Lopunny.converteranimations
{
	public class Lopunny_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private LO_LFS_SittingTo Lopunny_LFS_sittingto;
		
		private LO_LFS_WalkingTo Lopunny_LFS_walkingto;
		
		private LO_LFS_IdleTo Lopunny_LFS_idleto;

		public void LO_LFS_CoverterToAnimatorController()
		{
			Lopunny_LFS_walkingto.LO_LFS_WalkingToController();

			Lopunny_LFS_idleto.LO_LFS_IdleToController();
			
			Lopunny_LFS_sittingto.LO_LFS_SittingToController();	
		}
	}
}