using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.VoiceActorsFailSafeSys;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules
{
	public class FailSafeSysI : MonoBehaviour
	{
		private VoiceActorsFailSafetySys VAFSSys;
		private AnimatorFailSafetySys AFSSys;

		public void FSSys_I()
		{
			Get_VAFSys();
		}
		private void Get_VAFSys()
		{
			VAFSSys.VAFSSysI();
		}

		private void Get_AFSSys()
		{
			AFSSys.AFSSysI();
		}
	}
}