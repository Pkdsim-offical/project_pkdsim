using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.idlebaseanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.converteranimations;
using project_pkdsim.Generics.NPC.Species.Type;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Leafeon.Animator_I
{
	public class LFS_LeafeonFailSafe : MonoBehaviour 
	{
		public Animator Leafeon_Animator;
		public RuntimeAnimatorController someController;

		private NPCSpeciesType leafeon = NPCSpeciesType.LEAFEON;

		private Leafeon_LFS_ConverterAnimatorController LFSLeafeon_AnimatorCCA;
		private Leafeon_LFS_MovementAnimatorController LFSLeafeon_AnimatorCMA;
		private Leafeon_LFS_IdleAnimatorController LFSLeafeon_AnimatorICA;

		public void LoadFailSafeLeafeon_AnimatorController()
		{
			LoadFailSafeLeafeon_ConvertToAnimatorController();
			LoadFailSafeLeafeon_MovementAnimatorController();
			LoadFailSafeLeafeon_IdleAnimatorController();
		}
		private void LoadFailSafeLeafeon_ConvertToAnimatorController()
		{
			LFSLeafeon_AnimatorCCA.LE_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafeLeafeon_MovementAnimatorController()
		{
			LFSLeafeon_AnimatorCMA.LE_LFS_MovementAnimatorController();
		}
		private void LoadFailSafeLeafeon_IdleAnimatorController()
		{
			LFSLeafeon_AnimatorICA.LE_LFS_IdleAnimatorController();
		}
	}
}