using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.converteranimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.idlebaseanimation;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Jolteon.Animator_I
{
	public class LFS_JolteonFailSafe : MonoBehaviour 
	{
		public Animator Jolteon_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType jolteon = NPCSpeciesType.JOLTEON;

		private Jolteon_LFS_ConverterAnimatorController LFSJolteon_AnimatorCCA;
		private Jolteon_LFS_MovementAnimatorController LFSJolteon_AnimatorCMA;
		private Jolteon_LFS_IdleAnimatorController LFSJolteon_AnimatorICA;

		public void LoadFailSafeJolteon_AnimatorController()
		{
			LoadFailSafeJolteon_ConvertToAnimatorController();
			LoadFailSafeJolteon_MovementAnimatorController();
			LoadFailSafeJolteon_IdleAnimatorController();
		}
		private void LoadFailSafeJolteon_ConvertToAnimatorController()
		{
			LFSJolteon_AnimatorCCA.JT_LFS_IdleAnimatorController();
		}
		private void LoadFailSafeJolteon_MovementAnimatorController()
		{
			LFSJolteon_AnimatorCMA.JT_LFS_Base_IdleAnimatorController();
		}
		private void LoadFailSafeJolteon_IdleAnimatorController()
		{
			LFSJolteon_AnimatorICA.JT_LFS_Base_IdleAnimatorController();
		}
	}
}