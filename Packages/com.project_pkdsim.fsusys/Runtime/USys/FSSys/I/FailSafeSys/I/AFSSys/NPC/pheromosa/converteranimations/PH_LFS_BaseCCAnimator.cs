using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.IdleTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.SittingTo;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Pheromosa.converteranimations
{
	public class Pheromosa_LFS_ConverterAnimatorController : MonoBehaviour 
	{
		private PH_LFS_SittingTo Pheromosa_LFS_sittingto;
		
		private PH_LFS_WalkingTo Pheromosa_LFS_walkingto;
		
		private PH_LFS_IdleTo Pheromosa_LFS_idleto;

		public void PH_LFS_ConverterAnimatorController()
		{
			Pheromosa_LFS_walkingto.PH_LFS_WalkingToController();

			Pheromosa_LFS_idleto.PH_LFS_IdleToController();
			
			Pheromosa_LFS_sittingto.PH_LFS_SittingToController();	
		}
	}
}