using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.Modules.TABSys_OTBS;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_pkpediaLink.Modules
{
	public class TABSys_pkpediaLINK : MonoBehaviour 
	{
		private TABSys_OnTabSelected TABSys_OnTabSelect;
		public void TABSys_PkpediaLink() 
		{
			TABSys_OnTabSelect.DisplayCurrentTab();
		}
	}
}