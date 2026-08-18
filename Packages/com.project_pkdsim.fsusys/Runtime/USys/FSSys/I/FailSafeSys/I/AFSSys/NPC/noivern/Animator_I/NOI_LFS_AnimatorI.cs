using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Noivern.Animator_I
{
	public class LFS_NoivernFailSafe : MonoBehaviour 
	{
		public Animator Noivern_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType noivern = NPCSpeciesType.NOIVERN;

		private Noivern_LFS_ConverterAnimatorController LFSNoivern_AnimatorCCA;
		private Noivern_LFS_MovementAnimatorController LFSNoivern_AnimatorCMA;
		private Noivern_LFS_IdleAnimatorController LFSNoivern_AnimatorICA;


		public void LoadFailSafeNoivern_AnimatorController()
		{
			LoadFailSafeNoivern_ConvertToAnimatorController();
			LoadFailSafeNoivern_MovementAnimatorController();
			LoadFailSafeNoivern_IdleAnimatorController();
		}
		private void LoadFailSafeNoivern_ConvertToAnimatorController()
		{
			LFSNoivern_AnimatorCCA.NOI_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeNoivern_MovementAnimatorController()
		{
			LFSNoivern_AnimatorCMA.NOI_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeNoivern_IdleAnimatorController()
		{
			LFSNoivern_AnimatorICA.NOI_LFS_IdleAnimatorController();
		}
	}
}