using project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink.Modules;
using UnityEngine;

namespace project_pkdsim.USys.TABSys.Modules.TabManagerSys.Pkphone.TABSys_PkPhoneAPPS.TABSys_StoreLink
{
	public class TABSys_StoreLinker : MonoBehaviour 
	{
		private TABSys_StoreLINK TABSys_StoreLinkI;
		
		public void TABSys_storeLink() 
		{
			TABSys_StoreLinkI.TABSys_StoreMenuI();
		}
	}
}