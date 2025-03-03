using project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_PkpediaLink.I.TABSys_OTBS;
using UnityEngine;

namespace project_pkdsim.Assets.USys.TABSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_pkpediaLink.I
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