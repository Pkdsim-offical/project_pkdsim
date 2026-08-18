using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.converteranimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.movementbasedanimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Vaporeon.Animator_I
{
	public class LFS_VaporeonFailSafe : MonoBehaviour 
	{
		public Animator Vaporeon_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType vaporeon = NPCSpeciesType.VAPOREON;

		private Vaporeon_LFS_ConverterAnimatorController LFSVaporeon_AnimatorCCA;
		private Vaporeon_LFS_MovementAnimatorController LFSVaporeon_AnimatorCMA;
		private Vaporeon_LFS_IdleAnimatorController LFSVaporeon_AnimatorICA;

		public void LoadFailSafeVaporeon_AnimatorController()
		{
			
		}
		private void LoadFailSafeVaporeon_ConvertToAnimatorController()
		{
			LFSVaporeon_AnimatorCCA.VP_Base_IdleAnimatorController();
		}
		private void LoadFailSafeVaporeon_MovementAnimatorController()
		{
			LFSVaporeon_AnimatorCMA.VP_Base_IdleAnimatorController();
		}
		private void LoadFailSafeVaporeon_IdleAnimatorController()
		{
			LFSVaporeon_AnimatorICA.VP_LFS_Base_IdleAnimatorController();
		}
	}
}