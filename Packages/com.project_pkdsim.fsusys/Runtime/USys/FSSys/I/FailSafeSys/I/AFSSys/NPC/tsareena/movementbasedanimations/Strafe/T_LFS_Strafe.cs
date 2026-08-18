using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.NPC.Tsareena.movementbasedanimations.Strafing
{
	public class T_LFS_Strafing : MonoBehaviour 
	{
		private T_LFS_StrafeLeft T_strafeleft;
		
		private T_LFS_StrafeRight T_straferight;

		public void T_LFS_StrafingController()
		{
			if (T_strafeleft == null)
			{
				T_strafeleft = GetComponent<T_LFS_StrafeLeft>();
				Load_T_LFS_StrafeLeft();
			}
			if (T_straferight == null)
			{
				T_straferight = GetComponent<T_LFS_StrafeRight>();
				Load_T_LFS_StrafeRight();
			}
			

		}
		private void Load_T_LFS_StrafeRight()
		{
			T_straferight.T_LFS_StrafeRightController();
		}
		
		private void Load_T_LFS_StrafeLeft()
		{
			T_strafeleft.T_LFS_StrafeLeftController();
		}
	}
}