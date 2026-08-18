using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.idlebaseanimation;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.movementbasedanimations;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.converteranimations;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.PLAYER.Animator_I
{
	public class LFS_PLAYERFailSafe : MonoBehaviour 
	{
		public Animator PLAYER_Animator;
		public RuntimeAnimatorController someController;

		private Player_LFS_ConverterAnimatorController LFSPlayer_AnimatorCCA;
		private Player_LFS_MovementAnimatorController LFSPlayer_AnimatorCMA;
		private Player_LFS_IdleAnimatorController LFSPlayer_AnimatorICA;


		public void LoadFailSafePlayer_AnimatorController()
		{
			LoadFailSafePlayer_ConvertToAnimatorController();
			LoadFailSafePlayer_MovementAnimatorController();
			LoadFailSafePlayer_IdleAnimatorController();
		}
		private void LoadFailSafePlayer_ConvertToAnimatorController()
		{
			LFSPlayer_AnimatorCCA.PL_LFS_ConverterAnimatorController();
		}
		private void LoadFailSafePlayer_MovementAnimatorController()
		{
			LFSPlayer_AnimatorCMA.PL_LFS_MovementAnimatorController();
		}
		private void LoadFailSafePlayer_IdleAnimatorController()
		{
			LFSPlayer_AnimatorICA.PL_LFS_IdleAnimatorController();
		}
	}
}