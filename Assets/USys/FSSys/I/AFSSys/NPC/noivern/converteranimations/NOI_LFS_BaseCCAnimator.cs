using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.IdleTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.SittingTo;
using project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.Assets.USys.FSSys.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations
{
	public class Noivern_LFS_CoverterAnimatorController : MonoBehaviour 
	{
		private NOI_LFS_SittingTo Noivern_LFS_sittingto;
		
		private NOI_LFS_WalkingTo Noivern_LFS_walkingto;
		
		private NOI_LFS_IdleTo Noivern_LFS_idleto;

		public void NOI_LFS_CoverterToAnimatorController()
		{
			Noivern_LFS_walkingto.NOI_LFS_WalkingToController();

			Noivern_LFS_idleto.NOI_LFS_IdleToController();
			
			Noivern_LFS_sittingto.NOI_LFS_SittingToController();	
		}
	}
}